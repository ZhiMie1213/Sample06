using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode06 {
    public class Phones {
        public Phones( string userName ) {
            UserName = userName;
        }
        public string UserName {
            get; set;
        }

        public List<SmartPhone> MySmartPhones { get; set; } = new List<SmartPhone>( );
    }

    public class SmartPhone {
        public string OS {
            get; set;
        }
        public string ModelName {
            get; set;
        }
        public string CPU {
            get; set;
        }
        public int RAM {
            get; set;
        }
        public int ROM {
            get; set;
        }
        public SmartPhone( string os, string modelname, string cpu, int ram, int rom ) {
            OS = os;
            ModelName = modelname;
            CPU = cpu;
            RAM = ram;
            ROM = rom;
        }
    }

}
