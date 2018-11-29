using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBank
    {
        [OperationContract]
        [FaultContract(typeof(Hiba))]
        string Bejelentkezes(string uname, string passwd);

        [OperationContract]
        [FaultContract(typeof(Hiba))]
        string Kijelentkezes(string uid);

        [OperationContract]
        [FaultContract(typeof(Hiba))]
        string Feltoltes(int osszeg, string uid);

        [OperationContract]
        [FaultContract(typeof(Hiba))]
        string Lekerdezes(string uid);

        //kimeno: Sikeresen/sikertelenul utalasra kerult az <osszeg>, a <id> felhasznalonak
        [OperationContract]
        [FaultContract(typeof(Hiba))]
        Utal Utalas(string felhnev, int osszeg, string uid); 

        [OperationContract]
        [FaultContract(typeof(Hiba))]
        List<Utalasok> UtalasokList(string uid);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Utalasok
    {
        string nev;
        int osszeg;
        DateTime ido;

        [DataMember]
        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        [DataMember]
        public int Osszeg
        {
            get
            {
                return osszeg;
            }

            set
            {
                osszeg = value;
            }
        }

        [DataMember]
        public DateTime Ido
        {
            get
            {
                return ido;
            }

            set
            {
                ido = value;
            }
        }

        public Utalasok(string nev, int osszeg, DateTime ido)
        {
            this.nev = nev;
            this.osszeg = osszeg;
            this.ido = ido;
        }
    }

    [DataContract]
    public class Utal
    {
        string felhnev;
        int osszeg;
        bool eredmeny;

        [DataMember]
        public string Felhnev
        {
            get
            {
                return felhnev;
            }

            set
            {
                felhnev = value;
            }
        }

        [DataMember]
        public int Osszeg
        {
            get
            {
                return osszeg;
            }

            set
            {
                osszeg = value;
            }
        }

        [DataMember]
        public bool Eredmeny
        {
            get
            {
                return eredmeny;
            }

            set
            {
                eredmeny = value;
            }
        }
    }

    [DataContract]
    public class Hiba //Felul definialni az Exception osztalyt
    {
        string muvelet;
        string hibaTipusa;

        [DataMember]
        public string Muvelet
        {
            get
            {
                return muvelet;
            }

            set
            {
                muvelet = value;
            }
        }

        [DataMember]
        public string HibaTipusa
        {
            get
            {
                return hibaTipusa;
            }

            set
            {
                hibaTipusa = value;
            }
        }

    }
}
