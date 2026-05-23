using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FuncBUS
    {
        public List<FUNC> getParents()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.FUNCs.Where(x => x.ISGROUP == true && x.MENU == true).OrderBy(s => s.SORT).ToList();
            }
        }

        public List<FUNC> getChilds(string parent)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.FUNCs.Where(x => x.ISGROUP == false && x.MENU == true && x.PARENT == parent).OrderBy(s => s.SORT).ToList();
            }
        }
    }
}
