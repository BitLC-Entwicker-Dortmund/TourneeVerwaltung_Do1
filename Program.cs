using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourneeVerwaltung_Do1 {
    class Program {
        static void Main ( string [ ] args ) {
            Veranstaltung v = new Veranstaltung ( );

            Mitarbeiter m1 = new Mitarbeiter ( );
            Mitarbeiter m2 = new Mitarbeiter ( );
            Mitarbeiter m3 = new Mitarbeiter ( );

            v.AddMitarbeiter ( m1 );
            v.AddMitarbeiter ( m2 );
            v.AddMitarbeiter ( m3 );

            v = null;
        }
    }
}
}
