
using System.Runtime.CompilerServices;

namespace SampleCode06 {
    public class Program {
        public static void Main( string[ ] args ) {
            Deserialize( );
        }

        private const string JsonFilePath = @"C:\Users\22415\OneDrive\桌面\text.jon";

        private static void Serialize( ) {
            Phones phones = new Phones( "ben" );

            phones.MySmartPhones.Add( new SmartPhone( "iOS", "iPhone14ProMax", "A16", 6, 512 ) );
            string json = Newtonsoft.Json.JsonConvert.SerializeObject( phones );

            System.IO.File.WriteAllText( JsonFilePath, json );

            Console.WriteLine( "出力完了" );
        }

        private static void Deserialize( ) {
            string json = System.IO.File.ReadAllText( JsonFilePath );

            Phones phones = Newtonsoft.Json.JsonConvert.DeserializeObject<Phones>(json);

            Console.WriteLine( phones.MySmartPhones[0].ROM );
        }
    }
}