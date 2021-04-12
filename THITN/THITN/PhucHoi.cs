using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITN
{
    class PhucHoi
    {
        private Stack<string> myStack = new Stack<string>();
        private string DataTruocKhiSua = "";


        public string GetDataTruocKhiSua()
        {
            return this.DataTruocKhiSua;
        }

        public void PushStack_ThemSV(string newMaSV)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_THEMSV] '" + newMaSV + "'");
        }

        public void PushStack_XoaSV(string maSV, string ho, string ten, string ngaySinh, string diaChi, string maLop)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_XOASV] '" + maSV + "', N'" + ho + "', N'" + ten + "', N'" + ngaySinh + "', N'" + diaChi + "', N'" + maLop + "'");
        }

        public void Save_OldSV(string oldHo, string oldTen, string oldNgaySinh, string oldDiaChi, string oldMaLop)
        {
            DataTruocKhiSua = oldHo + "." + oldTen + "." + oldNgaySinh + "." + oldDiaChi + "." + oldMaLop;
        }

        public void PushStack_SuaSV(string newMaSV)
        {            
            string[] arr = DataTruocKhiSua.Split('.');
            myStack.Push("exec[dbo].[SP_PHUCHOI_SUASV] '" + newMaSV + "','" + arr[0] + "', N'" + arr[1] + "', N'" + arr[2] + "', N'" + arr[3] + "', N'" + arr[4] + "'");
        }

        //Khoa
        public void PushStack_ThemKhoa(string newMaKhoa)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_THEMKH] '" + newMaKhoa + "'");
        }

        public void PushStack_XoaKhoa(string maKhoa, string tenKhoa, string maCS)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_XOAKH] '" + maKhoa + "', N'" + tenKhoa + "', N'" + maCS + "'");
        }

        public void Save_OldKhoa(string oldMaKhoa, string oldTenKhoa, string oldMaCS)
        {
            DataTruocKhiSua = oldMaKhoa + "/" + oldTenKhoa + "/" + oldMaCS;
        }

        public void PushStack_SuaKhoa(string newMaKhoa, string newTenKhoa)
        {
            string[] arr = DataTruocKhiSua.Split('/');
            myStack.Push("exec[dbo].[SP_PHUCHOI_SUAKH] '" + newMaKhoa + "', N'" + newTenKhoa + "', '" + arr[0] + "', N'" + arr[1] + "', N'" + arr[2] + "'");
        }

        //Lớp
        public void PushStack_ThemLop(string newMaLop)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_THEMLOP] '" + newMaLop + "'");
        }

        public void PushStack_XoaLop(string maLop, string tenLop, string maKH)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_XOALOP] '" + maLop + "', N'" + tenLop + "', N'" + maKH + "'");
        }

        public void Save_OldLop(string oldMaLop, string oldTenLop, string oldMaKH)
        {
            DataTruocKhiSua = oldMaLop + "/" + oldTenLop + "/" + oldMaKH;
        }

        public void PushStack_SuaLop(string newMaLop, string newTenLop)
        {
            string[] arr = DataTruocKhiSua.Split('/');
            myStack.Push("exec[dbo].[SP_PHUCHOI_SUALOP] '" + newMaLop + "', N'" + newTenLop + "', '" + arr[0] + "', N'" + arr[1] + "', N'" + arr[2] + "'");
        }

        //Bộ đề
        public void PushStack_ThemBD(int newMaCauHoi)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_THEMBD] '" + newMaCauHoi.ToString() + "'");
        }

        public void PushStack_XoaBD(int maCauHoi, string maGV, string maMH, string trinhDo, string noiDung, string A, string B, string C, string D, string dapAn)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_XOABD] '" + maCauHoi.ToString() + "', '" + maGV + "', '" + maMH + "', '" + trinhDo + "', N'" + noiDung + "', N'" + A + "', N'" + B + "', N'" + C + "', N'" + D + "', '" + dapAn + "'");
        }

        public void Save_OldBD(int oldMaCauHoi, string oldMaGV, string oldMaMH, string oldTrinhDo, string oldNoiDung, string oldA, string oldB, string oldC, string oldD, string oldDapAn)
        {
            DataTruocKhiSua = oldMaCauHoi.ToString() + "/" + oldMaGV + "/" + oldMaMH + "/" + oldTrinhDo + "/" + oldNoiDung + "/" + oldA + "/" + oldB + "/" + oldC + "/" + oldD + "/" + oldDapAn;
        }

        public void PushStack_SuaBD()
        {
            string[] arr = DataTruocKhiSua.Split('/');
            myStack.Push("exec[dbo].[SP_PHUCHOI_SUABD] '" + arr[0] + "', '" + arr[1] + "', '" + arr[2] + "', '" + arr[3] + "', N'" + arr[4] + "', N'" + arr[5] + "', N'" + arr[6] + "', N'" + arr[7] + "', N'" + arr[8] + "', '" + arr[9] + "'");
        }

        //Môn học
        public void PushStack_ThemMH(string newMaMH)
        {
            myStack.Push("exec [dbo].[SP_PhucHoiThemMH] '" + newMaMH + "'");
        }
        public void PushStack_XoaMH(string maMH, string tenMH)
        {
            myStack.Push("exec [dbo].[SP_PhucHoiXoaMH] '" + maMH + "', N'" + tenMH + "'");
        }
        public void Save_OldMH(string oldMaMH, string oldTenMH)
        {
            DataTruocKhiSua = oldMaMH + "/" + oldTenMH;
        }

        public void PushStack_SuaMH(string newMaMH, string newTenMH)
        {
            string[] arr = DataTruocKhiSua.Split('/');
            myStack.Push("exec[dbo].[SP_PhucHoiSuaMH] '" + newMaMH + "', N'" + newTenMH + "', '" + arr[0] + "', N'" + arr[1] + "'");
        }



        //GIAO VIEN
        public void PushStack_ThemGV(string newMaGV)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_THEMGV] '" + newMaGV + "'");
        }
        public void PushStack_XoaGV(string oldMaGV, string oldHo, string oldTen, string oldHocVi, string oldMaKH)
        {
            myStack.Push("exec [dbo].[SP_PHUCHOI_XOAGV] '" + oldMaGV + "', N'" + oldHo + "', N'" + oldTen + "',  N'" + oldHocVi + "', '" + oldMaKH + "'");
        }
        public void Save_OldGV(string oldMaGV, string oldHo, string oldTen, string oldHocVi, string oldMaKH)
        {
            DataTruocKhiSua = oldMaGV + "/" + oldHo + "/" + oldTen + "/" + oldHocVi + "/" + oldMaKH;
        }
        public void PushStack_SuaGV(string oldMaGV, string oldHo, string oldTen, string oldHocVi, string oldMaKH)
        {
            string[] arr = DataTruocKhiSua.Split('/');
            myStack.Push("exec [dbo].[SP_PHUCHOI_SUAGV]  '" + arr[0] + "', N'" + arr[1] + "', N'" + arr[2] + "',N'" + arr[3] + "','" + arr[4] + "'   ");
        }

        //phục hồi
        public string PopStack()
        {
            if (myStack.Count == 0)
            {
                return "Đã phục hồi hết các thao tác, không thể phục hồi được nữa!";
            }
            string sql = myStack.Pop();
            Program.ExecSqlNonQuery(sql);
            return "success";
        }
    }
}
