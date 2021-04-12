using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITN
{
    public class CauHoi
    {
        private string idCauHoi;
        private string maMH;
        private string maGV;
        private string trinhDo;
        private string noiDung;
        private string a;
        private string b;
        private string c;
        private string d;
        private string dapAn;
        private string daChon;
        private string tempDapAn;

        public CauHoi()
        {
            this.idCauHoi = "";
            this.maMH = "";
            this.maGV = "";
            this.trinhDo = "";
            this.noiDung = "";
            this.a = "";
            this.b = "";
            this.c = "";
            this.d = "";
            this.dapAn = "";
            this.daChon = "";
        }
        public string IDCauHoi { get; set; }
        public string MaMH { get; set; }
        public string MaGV { get; set; }
        public string TrinhDo { get; set; }
        public string NoiDung { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string DapAn { get; set; }
        public string DaChon { get; set; }
        public string dapan { get; set; }

        public void Shuffle(string[] cauhoi)
        {
            Random random = new Random();
            for (int count = cauhoi.Count()-1; count >= 0; count--)
            {
                string i = cauhoi[random.Next(count)];
                cauhoi[count] = i;
            }
        }
        public void Tron()
        {
            string[] tempABCD = { this.A,this.B,this.C,this.D}; // a : "favorite" b: "favor", c: "favorable", d: "favorably", // a1: same b2: same as, c3: the same. d4: the same as 
            string[] tempABCD_2 = { "A","B","C","D"};
            for (int i = 0; i < tempABCD_2.Length; i++)
            {
                if (tempABCD_2[i].Equals(this.DapAn))
                {
                    tempDapAn = tempABCD[i];
                    break;
                }

            }
            Random rnd = new Random();
            string[] MyRandomArray = tempABCD.OrderBy(x => rnd.Next(4)).ToArray();
            string[] MyRandomArray2 = MyRandomArray.OrderByDescending(x => rnd.Next(6)).ToArray();


            this.A = MyRandomArray2[0];
            this.B = MyRandomArray2[1];
            this.C = MyRandomArray2[2];
            this.D = MyRandomArray2[3];

            for (int i = 0; i < tempABCD_2.Length; i++)
            {
                if (tempDapAn.Equals(MyRandomArray2[i]))
                {
                    this.DapAn = tempABCD_2[i];
                    break;
                }
            }
        }

    }
}
