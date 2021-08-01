using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATO.DAO;
using NATO.DTO;

namespace NATO.BUS
{
    public class MatHang_BUS
    {
        public static MatHang_BUS instance;
        public static MatHang_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHang_BUS();
                return instance;
            }
        }

        public bool themMatHang(MatHang_DTO mh)
        {
            return MatHang_DAO.Instance.themmatHang(mh);
        }

        public List<MatHang_DTO> getAllMatHang()
        {
            return MatHang_DAO.Instance.getAllMatHang();
        }

        public List<MatHang_DTO> getMHbyDM(string mdm)
        {
            return MatHang_DAO.Instance.getMHbyDM(mdm);
        }

        public List<MatHang_DTO> searchMatHang(string str)
        {
            return MatHang_DAO.Instance.searchMatHang(str);
        }

        public MatHang_DTO getMHbyMaMH(string maMH)
        {
            return MatHang_DAO.Instance.getMHbyMaMH(maMH);
        }

        public bool capNhatMH(string maMH, MatHang_DTO mh)
        {
            return MatHang_DAO.Instance.capNhatMH(maMH, mh);
        }
    }
}
