using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourneeVerwaltung_Do1 {
	class Veranstaltung {
		private Mitarbeiter [ ] mitarbeiter = new Mitarbeiter [ 3 ];
		private int pos = 0;

		public void SetMitarbeiter ( Mitarbeiter [ ] MAvonAussen ) {
			mitarbeiter = MAvonAussen;
		}

		public Mitarbeiter [ ] GetMitarbeiter ( ) {
			return mitarbeiter;
		}

		public void AddMitarbeiter ( Mitarbeiter m ) {
			if ( pos < mitarbeiter.Length )
				mitarbeiter [ pos ] = m;
			pos++;
		}


		public Veranstaltung ( ) { }  // standardkonstruktor

		public Veranstaltung ( int groesse ) {
			mitarbeiter = new Mitarbeiter [ groesse ];
		}
	}
}
