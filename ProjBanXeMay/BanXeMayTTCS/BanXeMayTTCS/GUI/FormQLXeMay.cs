using BanXeMayTTCS.DAO;
using BanXeMayTTCS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.GUI
{
    public partial class FormQLXeMay : Form
    {
        private List<XeMay> listXeMay; //thể hiện thông tin của xe máy
        //BindingSource dùng để liên kết dữ liệu giữa nguồn DL và các điều khiển giao diện người dùng
        private BindingSource bindingSource = new BindingSource(); 
        
        //khi người dùng sử dụng, giá trị được gán là 0 or 1 
        private const int CHUCNANG_THEM = 0;
        private const int CHUCNANG_SUA = 1;
        private int chucNangThucThi; //lưu trạng thái hiện tại của chương trình 

        private int position;//lưu vị trí (index) của một phần tử trong danh sách listXeMay (coi xe nào được chọn hoặc thao tác)
        private string hinhAnh; //lưu đường dẫn hoặc tên file của hình ảnh xe máy

        private const string TRANGTHAI_DEFAULT = "THH";
        public FormQLXeMay()
        {
            InitializeComponent();
            LoadUI();//thiết lập giao diện gồm các combo box và trạng thái mặc định
            LoadData();//tải DL
        }
        #region Giao diện
        private void LoadData()
        {
            listXeMay = XeMayDAO.Instance.GetListXeMay();//lớp XeMayDao gọi phương thức GetListXeMay
            bindingSource.DataSource = listXeMay; //Gán danh sách xe máy vào bindingSource để liên kết dữ liệu
            gridControlXeMay.DataSource = bindingSource; //Gán bindingSource vào gridControlXeMay hiển thị ds lên giao diện
            bindingSource.Position = 0;//đặt con trỏ của bindingSource vị trí đầu tiên (chọn xe máy đầu tiên trong ds)
        }
        private void LoadUI()
        {
            ResetTatCaComponent();
            // Combobox trạng thái:hiển thị ds trạng thái từ GetListTrangThai 
            comboBoxTrangThai.DataSource = XeMayDAO.Instance.GetListTrangThai();
            comboBoxTrangThai.DisplayMember = "TrangThai"; //tên trạng thái
            comboBoxTrangThai.ValueMember = "MaTrangThai"; //giá trị mã trạng thái
            // Combobox loại xe máy: hiển thị ds loại từ GetListLoai
            comboBoxLoai.DataSource = XeMayDAO.Instance.GetListLoai();
            comboBoxLoai.DisplayMember = "TenLoai";
            comboBoxLoai.ValueMember = "MaLoai";
            // Combobox hãng xe máy: tương tự
            comboBoxHang.DataSource = XeMayDAO.Instance.GetListHang();
            comboBoxHang.DisplayMember = "TenHang";
            comboBoxHang.ValueMember = "MaHang";
            // Combobox nhà cung cấp: tương tự
            comboBoxNhaCungCap.DataSource = XeMayDAO.Instance.GetLisNhaCungCap();
            comboBoxNhaCungCap.DisplayMember = "TenNhaCungCap";
            comboBoxNhaCungCap.ValueMember = "MaNhaCungCap";
        }
        //điền thông tin của xe máy từ ListXeMay vào các dkhien: textbox, combobox, picturebox  
        private void FillInput()
        {
            position = bindingSource.Position;//Lấy vị trí hiện tại của xe máy được chọn trong bindingSource
            //Lấy đối tượng XeMay tại vtri đó,gán thuộc tính của dongHo
            //(mã, tên, giá, số lượng, mô tả, trạng thái, loại, hãng, nhà cung cấp, hình ảnh) vào các điều khiển tương ứng
            XeMay dongHo = listXeMay[position];
            txtMaXeMay.Text = dongHo.MaXeMay;
            txtTenXeMay.Text = dongHo.TenXeMay;
            txtGia.Text = Convert.ToString(dongHo.Gia);
            txtSoLuongTon.Text = Convert.ToString(dongHo.SoLuongTon);
            txtMoTa.Text = dongHo.MoTa;
            comboBoxTrangThai.Text = dongHo.TrangThai;
            comboBoxLoai.Text = dongHo.Loai;
            comboBoxHang.Text = dongHo.Hang;
            comboBoxNhaCungCap.Text = dongHo.NhaCungCap;
            this.hinhAnh = dongHo.HinhAnh;
            try
            {//tải hình ảnh từ path được định dạng bởi MyFormat.GetFilePath
                pictureBoxHinhAnh.Image = Image.FromFile(MyFormat.GetFilePath(dongHo.HinhAnh));
            }
            catch (Exception e)
            {// nếu lỗi hiển thị hình ảnh lỗi mặc định và thông báo lỗi
                pictureBoxHinhAnh.Image = pictureBoxHinhAnh.ErrorImage;
                MessageBox.Show(e.Message);
            }
            if(chucNangThucThi == -1)
            {// kiểm tra trạng thái xe máy=>Trạng thái default, ko thêm/sửa=> vô hiệu hóa nút sửa và ngừng kinh doanh
             // ngược lại thì bật
                btnNgungKinhDoanh.Enabled = btnSua.Enabled = dongHo.TrangThai.Equals("Ngừng kinh doanh") ? false : true;
            }
        }
        //Đặt lại trạng thái của các thành phần giao diện
        private void ResetTatCaComponent()
        {   //đặt về trạng thái mặc định
            chucNangThucThi = -1;
            // Enable các input và chuyển về ReadOnly: bật và chỉ cho xem
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(true);
            // Enable Grid control xe máy: tooltripMenu (chứa các button)
            gridControlXeMay.Enabled = true;
            // Enable tất cả nút trừ Ghi và Thoát chức năng
            ThayDoiButtonEnabled(true);
            btnGhi.Enabled = false;
            btnThoatChucNang.Enabled = false;
        }
        //Xóa or đặt lại giá trị mặc định cho các ô nhập DL
        private void ResetGiaTriInput()
        {
            txtMaXeMay.ResetText();
            txtTenXeMay.ResetText();
            txtGia.ResetText();
            txtSoLuongTon.ResetText();
            txtMoTa.ResetText();
            //SelectedIndex=0 :Đặt các combobox về lựa chọn đầu tiên
            comboBoxTrangThai.SelectedIndex = 0;
            comboBoxLoai.SelectedIndex = 0;
            comboBoxHang.SelectedIndex = 0;
            comboBoxNhaCungCap.SelectedIndex = 0;
            hinhAnh = ""; //xóa đường dẫn hình ảnh
            pictureBoxHinhAnh.Image = pictureBoxHinhAnh.InitialImage; // đặt ảnh mặc định
        }
        // Bật/tắt các ô nhập liệu dựa trên tham số enabled
        private void ThayDoiInputEnabled(bool enabled)
        {
            txtMaXeMay.Enabled = enabled;
            txtTenXeMay.Enabled = enabled;
            txtGia.Enabled = enabled;
            txtSoLuongTon.Enabled = enabled;
            txtMoTa.Enabled = enabled;
            comboBoxTrangThai.Enabled = enabled;
            comboBoxLoai.Enabled = enabled;
            comboBoxHang.Enabled = enabled;
            comboBoxNhaCungCap.Enabled = enabled;
        }
        // Chỉ đọc or có thể chỉnh sửa
        private void ThayDoiInputReadOnly(bool readOnly)
        {
            //ReadOnly = readOnly: Đặt textbox thành chỉ đọc nếu true
            //Enabled = !readOnly: Combobox chỉ bật khi không ở chế độ chỉ đọc
            txtMaXeMay.ReadOnly = readOnly;
            txtTenXeMay.ReadOnly = readOnly;
            txtGia.ReadOnly = readOnly;
            txtSoLuongTon.ReadOnly = readOnly;
            txtMoTa.ReadOnly = readOnly;
            comboBoxTrangThai.Enabled = !readOnly;
            comboBoxLoai.Enabled = !readOnly;
            comboBoxHang.Enabled = !readOnly;
            comboBoxNhaCungCap.Enabled = !readOnly;
        }
        // Bật/tắt tất cả các nút dựa trên tham số enabled
        private void ThayDoiButtonEnabled(bool enabled)
        {
            btnThem.Enabled = enabled;
            btnSua.Enabled = enabled;
            btnGhi.Enabled = enabled;
            btnXoa.Enabled = enabled;
            btnNgungKinhDoanh.Enabled = enabled;
            btnTaiLai.Enabled = enabled;
            btnThoatChucNang.Enabled = enabled;
        }
        #endregion Giao diện
        #region Chức năng
        
        // Kiểm trá tính hợp lệ của DL đầu vào vào trước khi thêm hoặc sửa xe máy
        private bool InputHopLe()
        {
            if (txtMaXeMay.Text.Equals(""))
            {
                MessageBox.Show("Mã xe máy không được trống");
                return false;
            }
            if (txtTenXeMay.Text.Equals(""))
            {
                MessageBox.Show("Tên xe máy không được trống");
                return false;
            }
            if (txtGia.Text.Equals(""))
            {
                MessageBox.Show("Giá bán xe máy không được trống");
                return false;
            }
            if (hinhAnh.Equals(""))
            {
                MessageBox.Show("Hình đại diện không được trống");
                return false;
            }
            return true;
        }
        //Thêm xe máy mới vào csdl và giao diện
        private void ThemXeMay()
        {
            string maXeMay = txtMaXeMay.Text;
            string tenXeMay = txtTenXeMay.Text;
            decimal gia = decimal.Parse(txtGia.Text);
            int soLuongTon = int.Parse(txtSoLuongTon.Text);
            string moTa = txtMoTa.Text;
            string trangThai = (string)comboBoxTrangThai.SelectedValue;
            string hinhAnh = Path.GetFileName(this.hinhAnh);
            string loai = (string)comboBoxLoai.SelectedValue;
            string hang = (string)comboBoxHang.SelectedValue;
            string nhaCungCap = (string)comboBoxNhaCungCap.SelectedValue;
            XeMay dongHo = new XeMay(maXeMay, tenXeMay, gia, soLuongTon, moTa, trangThai, hinhAnh, loai, hang, nhaCungCap);
            //gọi phương thức thêm xe máy của lớp XeMayDAO
            if (XeMayDAO.Instance.ThemXeMay(dongHo))
            {
                // Chuyển ảnh đến folder resource
                if(!File.Exists(MyFormat.PATH_RESOURCE + dongHo.HinhAnh))
                {
                    try
                    {// sao chép file đường dẫn this.hinhAnh vào thư mục tài nguyên
                        File.Copy(this.hinhAnh, MyFormat.PATH_RESOURCE + dongHo.HinhAnh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: Lỗi chuyển file. " + ex.Message);
                    }
                }
                // Thay mã bằng giá trị
                MessageBox.Show("Thêm xe máy thành công");
                //cập nhật các thuộc tính từ value sang text
                dongHo.TrangThai = comboBoxTrangThai.Text;
                dongHo.Loai = comboBoxLoai.Text;
                dongHo.Hang = comboBoxHang.Text;
                dongHo.NhaCungCap = comboBoxNhaCungCap.Text;
                // Thêm vào gridview
                listXeMay.Add(dongHo); // Thêm xemay vào ListXeMay
                gridViewXeMay.RefreshData();
                bindingSource.Position = listXeMay.Count - 1; //đặt con trỏ về xemay vừa thêm
                // Reset: đặt lại giao diện
                ResetTatCaComponent();
            }
            else
                MessageBox.Show("Thêm xe máy thất bại");
        }
        private void SuaXeMay()
        {
            string maXeMay = txtMaXeMay.Text;
            string tenXeMay = txtTenXeMay.Text;
            decimal gia = decimal.Parse(txtGia.Text);
            string moTa = txtMoTa.Text;
            string trangThai = (string)comboBoxTrangThai.SelectedValue;
            string hinhAnh = Path.GetFileName(this.hinhAnh);
            string loai = (string)comboBoxLoai.SelectedValue;
            string hang = (string)comboBoxHang.SelectedValue;
            XeMay dongHo = new XeMay(maXeMay, tenXeMay, gia, moTa, trangThai, hinhAnh, loai, hang);
            if (XeMayDAO.Instance.SuaXeMay(dongHo))
            {
                MessageBox.Show("Sửa thông tin xe máy thành công");
                // Cập nhật đối tượng cũ trong listXeMay với thông tin mới
                XeMay dongHoCu = listXeMay[bindingSource.Position];
                // Chuyển ảnh đến folder Image
                if(listXeMay[bindingSource.Position].HinhAnh != this.hinhAnh)
                {
                    if (!File.Exists(MyFormat.PATH_RESOURCE + dongHo.HinhAnh))
                    {
                        try
                        {
                            File.Copy(this.hinhAnh, MyFormat.PATH_RESOURCE + dongHo.HinhAnh);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: Lỗi chuyển file. " + ex.Message);
                        }
                    }
                }
                dongHoCu.TenXeMay = tenXeMay;
                dongHoCu.Gia = gia;
                dongHoCu.MoTa = moTa;
                dongHoCu.TrangThai = comboBoxTrangThai.Text;
                dongHoCu.HinhAnh = hinhAnh;
                dongHoCu.Loai = comboBoxLoai.Text;
                dongHoCu.Hang = comboBoxHang.Text;
                gridViewXeMay.RefreshData();
                // Reset
                ResetTatCaComponent();
            }
            else
                MessageBox.Show("Thêm xe máy thất bại");
        }
        private void XoaXeMay()
        {// Xóa xemay dựa trên mã xe máy
            if (XeMayDAO.Instance.XoaXeMay(txtMaXeMay.Text))
            {
                MessageBox.Show("Xóa xe máy thành công");
                //xóa xe may khỏi ListXeMay
                listXeMay.RemoveAt(bindingSource.Position);
                bindingSource.Position = 0; //đặt con trỏ về đầu ds
                gridViewXeMay.RefreshData();
                ResetTatCaComponent();
            }
            else
                MessageBox.Show("Xóa xe máy thất bại");
        }
        // Chuẩn bị giao diện cho chức năng thêm hoặc sửa
        private void ThucThiChucNang()
        {
            // Disable tất cả nút chức năng khác trừ Ghi và Thoát
            ThayDoiInputEnabled(true);
            ThayDoiInputReadOnly(false);
            ThayDoiButtonEnabled(false);
            btnGhi.Enabled = true;
            btnThoatChucNang.Enabled = true;
            // Thực thi
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    gridControlXeMay.Enabled = false; //tắt bảng ds
                    ResetGiaTriInput(); // xóa trắng ô nhập liệu
                    txtSoLuongTon.Text = "0";
                    txtSoLuongTon.ReadOnly = true;
                    comboBoxTrangThai.SelectedValue = TRANGTHAI_DEFAULT;
                    comboBoxTrangThai.Enabled = false; // tắt combo box trạng thái
                    break;
                case CHUCNANG_SUA:
                    txtSoLuongTon.ReadOnly = true;
                    comboBoxNhaCungCap.Enabled = false;
                    comboBoxTrangThai.Enabled = false;
                    break;
            }
        }
        // Ghi dữ liệu dựa trên chức năng đang thực thi
        private void GhiDuLieu()
        {
            switch (chucNangThucThi)
            {
                case CHUCNANG_THEM:
                    if (InputHopLe())
                        ThemXeMay();
                    break;
                case CHUCNANG_SUA:
                    if (InputHopLe())
                    {
                        SuaXeMay();
                    }
                    break;
            }
        }
        #endregion Chức năng
        // Các sự kiện trong lớp FormQLXeMay
        
        //Khi người dùng chọn một xe máy trong bảng
        //thông tin chi tiết của xe máy đó sẽ tự động hiển thị trên các ô nhập liệu để xem hoặc chỉnh sửa.
        //Xử lý sự kiện khi người dùng thay đổi dòng được chọn (focused row) trong gridViewXeMay (hiển thị ds xemay)
        private void gridViewXeMay_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillInput(); //điền thông tin của xe máy từ dòng được chọn vào các ô nhập liệu
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {   // do CHUCNANG_THEM được định nghĩa gán gtri =0 nên tương đương gán cho biến chucNangThucThi
            // biểu thị chức năng hiện tại là thêm xemay ms
            chucNangThucThi = CHUCNANG_THEM;
            ThucThiChucNang(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucNangThucThi = CHUCNANG_SUA;
            ThucThiChucNang();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {   //Nút "Ghi" thực hiện việc lưu dữ liệu (thêm hoặc sửa) sau khi người dùng nhập xong thông tin
            GhiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn xóa xe máy này?\nSau khi xóa không thể phục hồi",
                "Xóa xe máy", 
                MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                XoaXeMay();
            }
        }
        private void btnNgungKinhDoanh_Click(object sender, EventArgs e)
        {
            if(listXeMay.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có thực sự muốn ngừng kinh doanh sản phẩm này?\nSau khi thực hiện sẽ không thể kinh doanh lại",
                    "Ngừng kinh doanh sản phẩm",
                    MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    XeMay dongHo = listXeMay[bindingSource.Position];
                    if (XeMayDAO.Instance.NgungKinhDoanhSP(dongHo.MaXeMay))
                    {
                        MessageBox.Show("Ngừng kinh doanh sản phẩm thành công");
                    }
                    else
                        MessageBox.Show("Ngừng kinh doanh sản phẩm thất bại");
                }
            }
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoatChucNang_Click(object sender, EventArgs e)
        {
            ResetTatCaComponent();
            FillInput();
        }
        private void pictureBoxHinhAnh_Click(object sender, EventArgs e)
        {
            if(chucNangThucThi == CHUCNANG_THEM || chucNangThucThi == CHUCNANG_SUA)
            {
                if (openFileDialogChonAnh.ShowDialog() == DialogResult.OK)
                {
                    hinhAnh = openFileDialogChonAnh.FileName;
                    pictureBoxHinhAnh.Image = Image.FromFile(hinhAnh);
                }
            }
        }

        private void txtMaXeMay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /*KeyPressEventArgs e: Đối tượng chứa thông tin về phím vừa được nhấn
         * trong đó e.KeyChar là ký tự tương ứng với phím đó.
          KeyPress khi người dùng nhấn một phím trên bàn phím trong ô txtMaXeMay*/
        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // sự kiện đã được xử lý và ký tự này sẽ không được nhập vào ô textbox
            }
        }
    }
}
