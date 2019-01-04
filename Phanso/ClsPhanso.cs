using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanso
{
  public class ClsPhanso
    {
        private int ts, ms;
        public int tuso
        {
            get { return ts; }
            set
            {
                ts = value;
            }
        }
        public int mauso
        {
            get { return ms; }
            set
            {
                if (value == 0)
                    ms = 1;
                else
                    ms = value;
            }
        }
        public ClsPhanso()
        {
            ts = 0;
            ms = 1;
        }
        public ClsPhanso(int paraTuso,int paraMauso)
        {   
            ts = paraTuso;
            ms = paraMauso;
        }
        private int USCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public void Toigian()
        {
            int liUSCLN = USCLN(ts, ms);
            ts = ts / liUSCLN;
            ms = ms / liUSCLN;
        }
        public static ClsPhanso Cong(ClsPhanso a,ClsPhanso b)
        {
            ClsPhanso c = new ClsPhanso();
            c.ts = a.ts * b.ms + b.ts * a.ms;
            c.ms = a.ms * b.ms;
            c.Toigian();
            return c;
        }
        public static ClsPhanso Tru(ClsPhanso a,ClsPhanso b)
        {
            ClsPhanso c = new ClsPhanso();
            c.ts = a.ts * b.ms - b.ts * a.ms;
            c.ms = a.ms * b.ms;
            c.Toigian();
            return c;
        }
        public static ClsPhanso Nhan(ClsPhanso a, ClsPhanso b)
        {
            ClsPhanso c = new ClsPhanso();
            c.ts = a.ts * b.ts;
            c.ms = a.ms * b.ms;
            c.Toigian();
            return c;
        }
        public static ClsPhanso Chia(ClsPhanso a, ClsPhanso b)
        {
            ClsPhanso c = new ClsPhanso();
            c.ts = a.ts * b.ms;
            c.ms = a.ms * b.ts;
            c.Toigian();
            return c;
        }
    }
}
