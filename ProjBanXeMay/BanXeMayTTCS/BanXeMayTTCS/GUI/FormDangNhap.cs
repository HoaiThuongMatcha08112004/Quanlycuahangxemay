using BanXeMayTTCS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanXeMayTTCS.GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private bool InputHopLe()
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được trống"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được trống"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                if (DangNhapDAO.Instance.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text)) //Gọi phương thức DangNhap của DangNhapDAO để kiểm tra thông tin đăng nhập
                {/*DangNhapDAO.Instance: Đây là một đối tượng của class DangNhapDAO
                  * sử dụng mẫu thiết kế Singleton (vì có Instance). 
                  * Singleton đảm bảo chỉ có một instance duy nhất của DangNhapDAO trong toàn bộ ứng dụng.*/
                    MessageBox.Show("Đăng nhập thành công. " + DangNhapDAO.Instance.Nhom
                        , "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    if (DangNhapDAO.Instance.Nhom.Equals(DangNhapDAO.NHOM_NHANVIEN) ||
                        DangNhapDAO.Instance.Nhom.Equals(DangNhapDAO.NHOM_QUANTRI))
                    {
                        //Nếu người dùng là Nhân viên hoặc Quản trị, mở form chính dành cho họ
                        new FormMainNV(this).ShowDialog();
                    }
                    else if (DangNhapDAO.Instance.Nhom.Equals(DangNhapDAO.NHOM_KHACHHANG))
                    {
                        // tương tự mở form dành cho khách hàng
                        new FormMainKH(this).ShowDialog();
                    } 
                }
            }
        }

        private void labelDangKy_Click(object sender, EventArgs e)
        /*form đăng ký sẽ được mở, và sau khi người dùng đăng ký thành công, 
         * thông tin tài khoản và mật khẩu sẽ được điền tự động vào các ô nhập liệu trên form hiện tại.*/
        {
            FormDangKy form = new FormDangKy();
            form.ShowDialog(); //hiển thị form đki dưới dạng modal (ng dùng ko thể contact vs form dnhap)
            if (form.IsAdded) //Kiểm tra xem người dùng có đăng ký thành công hay không
            {
                txtTaiKhoan.Text = form.TaiKhoan;
                txtMatKhau.Text = form.MatKhau;
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Điều kiện này kiểm tra xem ký tự mà người dùng vừa nhập có phải là ký tự không mong muốn
            //(không phải chữ cái, không phải số, và không phải ký tự điều khiển) hay không.
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            //Nếu ký tự không phải là ký tự điều khiển (như Backspace), điều kiện này sẽ là true
            //Nếu ký tự không phải là chữ cái hoặc số (ví dụ: @, #, $, v.v.), điều kiện này sẽ là true.
            {
                e.Handled = true;
            }
        }
    }
}
