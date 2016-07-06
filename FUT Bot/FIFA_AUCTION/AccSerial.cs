using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    public partial class Account {
        static public void write(Account acc, StreamWriter writer, string KEY) {
            writer.WriteLine(Cip.Cipher.encipher(acc.details.Username, true, KEY));
            writer.WriteLine(Cip.Cipher.encipher(acc.details.Password, true, KEY));
            writer.WriteLine(Cip.Cipher.encipher(acc.details.SecretAnswer, true, KEY));
            writer.WriteLine(Cip.Cipher.encipher(acc.details.Platform.ToString(), true, KEY));
            writer.WriteLine(Cip.Cipher.encipher(acc.cards.Count.ToString(), true, KEY));
            foreach (Card card in acc.cards.Values) {
                StringWriter strWriter = new StringWriter();
                XmlSerializer serializer = new XmlSerializer(typeof(Card));
                serializer.Serialize(strWriter, card);
                writer.WriteLine(Cip.Cipher.encipher(strWriter.ToString(), true, KEY));
            }
        }

        static public Account read(StreamReader reader, string KEY) {
            string email, pass, answer, platf;
            email = Cip.Cipher.decipher(reader.ReadLine(), true, KEY);
            pass = Cip.Cipher.decipher(reader.ReadLine(), true, KEY);
            answer = Cip.Cipher.decipher(reader.ReadLine(), true, KEY);
            platf = Cip.Cipher.decipher(reader.ReadLine(), true, KEY);
            LoginDetails details = new LoginDetails(email, pass, answer, (platf == "Ps3" ? Platform.Ps3 : (platf == "Xbox360" ? Platform.Xbox360 : Platform.Pc)));
            List<Card> cards = new List<Card>();
            int count = Convert.ToInt32(Cip.Cipher.decipher(reader.ReadLine(), true, KEY));
            for (int i = 0; i < count; i++) {
                cards.Add(readCard(reader, KEY));
            }
            return new Account(details, cards);
        }

        static Card readCard(StreamReader reader, string KEY) {
            string xmlDoc = Cip.Cipher.decipher(reader.ReadLine(), true, KEY);
            StringReader strReader = new StringReader(xmlDoc);
            XmlSerializer serializer = new XmlSerializer(typeof(Card));
            return (Card)serializer.Deserialize(strReader);
        }
    }
}
