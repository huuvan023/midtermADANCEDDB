using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeam100_DB4O
{
    [Serializable]
    public class CongTy
    {
        public Guid MaCongTy { get; set; }
		public string MaSoThue { get; set; }
        public string TenCongTy { get; set; }
        public string SoNha { get; set; }
        public string DuongPho { get; set; }
        public string QuanHuyen { get; set; }
		public NhanVien GiamDoc { get; set; }

        public CongTy(Guid MaCongTy, string MaSoThue, string TenCongTy, string SoNha, string DuongPho, string QuanHuyen, NhanVien GiamDoc)
        {
            this.MaCongTy = MaCongTy;
            this.MaSoThue = MaSoThue;
            this.TenCongTy = TenCongTy;
            this.SoNha = SoNha;
            this.DuongPho = DuongPho;
            this.QuanHuyen = QuanHuyen;
            this.GiamDoc = GiamDoc;
        }
        public override string ToString()
        {
            return TenCongTy;
        }
    }
}
