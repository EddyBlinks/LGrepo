using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterdorfTelefonbuch
{
    class TelefonBuch
    {
        public TelefonBuchEintrag[] telein;

        public TelefonBuch(TelefonBuchEintrag[] telein)
        {
            this.telein = telein;
        }

        public void AllesAnzeigen()
        {
            foreach (TelefonBuchEintrag item in telein)
            {
                item.AusgabeTelEintrag();
            }

            //for (int i = 0; i < telein.Length; i++)
            //{
            //    TelefonBuchEintrag item = telein[i];
            //    item.AusgabeTelEintrag();
            //}
        }
    }
}
