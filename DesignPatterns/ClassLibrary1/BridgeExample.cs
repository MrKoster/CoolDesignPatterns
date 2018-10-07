using System;

namespace BridgeDesignPattern
{
    public class BridgeExample
    {
        /// <summary>
        /// Example use of our bridge design pattern.
        /// Press F5 to run.
        /// </summary>
        public static void Main(string[] args)
        {
            // Creating package senders
            IPackageSender dhlSender = new DhlSender();
            IPackageSender fedexSender = new FedexSender();

            Package letter = new LetterPackage();
            letter.address = "4365 Spring Avenue, ROAN MOUNTAIN, Tennessee";
            letter.message = "Giraffes don't exist.";
            // Sending via different transportes
            letter.packageSender = dhlSender;
            letter.SendPackage();
            letter.packageSender = fedexSender;
            letter.SendPackage();

            Package parcel = new ParcelPackage();
            parcel.address = "550  Dola Mine Road, OVERLAND PARK, Kansas";
            parcel.message = "Some fancy cake.";
            // Sending via different transportes
            parcel.packageSender = dhlSender;
            parcel.SendPackage();
            parcel.packageSender = fedexSender;
            parcel.SendPackage();

            Package palet = new PaletPackage();
            palet.address = "306  Elk City Road, Shreveport, Louisiana";
            palet.message = "Lots of empty lunchboxes.";
            // Sending via different transportes
            palet.packageSender = dhlSender;
            palet.SendPackage();
            palet.packageSender = fedexSender;
            palet.SendPackage();

            Console.ReadLine();
        }
    }
}
