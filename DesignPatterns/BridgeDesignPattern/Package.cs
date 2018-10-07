using System;

/// <summary>
/// 
/// GLOSSARY :
/// 
/// Implementor Interface: This interface that provides preliminary operations for all concrete implementations.
/// So in human terms - it says what classes that implement this guy will have to do.
/// 
/// 
/// Concrete Implementors: As name says, concrete classes for Implementor Interface. 
/// Each one does stuff declared in Implementor Interface, but in thier own way. 
/// (In our examlple, Dhl sender will send packages by DHL company, and Fedex sender will
/// send packages by Fedex company, You know, those big transport companies)
/// 
/// 
/// Abstraction: It basically defines business object, in our case - package.
/// Note that it has reference to Implementator (by Implementator Interface).
/// Why? Because we will want to call concrete implementations of method SendPackage!
/// 
/// 
/// Real/Redefined Abstraction: Real abstraction class (sounds wierd when I think about it now).
/// But generally that's what it is, it's a class that does have 
/// it's own implementation as well as call to SendPackage method from 
/// base abstraction. Remember? Base absctraction has reference to Implementor!
/// That's how we made many to many relation without 
/// class explosion (like really significant number of classes), yay!
/// 
/// </summary>


namespace BridgeDesignPattern
{
    /// <summary>
    /// Implementor Interface
    /// Our Concrete Implementations will have to be able to send message to given address.
    /// This is the "Bridge" that connects implementation and abstraction. 
    /// In our case, it connects packages with package senders.s
    /// </summary>
    public interface IPackageSender
    {
        void SendPackage(string message, string address);
    }

    /// <summary>
    /// Concrete Implementor nr 1
    /// Note how it sends given message to given address by DHL COMPANY!
    /// </summary>
    public class DhlSender : IPackageSender
    {
        private const string transporterName = "DHL";
        public void SendPackage(string message, string address)
        {
            Console.WriteLine($"Sending {message} to {address} by {transporterName}");
        }
    }

    /// <summary>
    /// Concrete Implementor nr 2s
    /// Note how it sends given message to given address by FEDEX COMPANY!
    /// </summary>
    public class FedexSender : IPackageSender
    {
        private const string transporterName = "Fedex";
        public void SendPackage(string message, string address)
        {
            Console.WriteLine($"Sending {message} to {address} by {transporterName}");
        }
    }

    /// <summary>
    /// Abstraction.
    /// </summary>
    public abstract class Package
    {
        public IPackageSender packageSender;
        public string message;
        public string address;
        public abstract void SendPackage();
    }

    /// <summary>
 
    /// </summary>
    public class LetterPackage : Package
    {
        public override void SendPackage()
        {
            var packedMessage = $"<Envelope>{message}</Envelope>";
            packageSender.SendPackage(packedMessage, address);
        }
    }

    /// <summary>
    /// Same as with Letter package, for small packages, parcels.
    /// </summary>
    public class ParcelPackage : Package
    {
        public override void SendPackage()
        {
            var packedMessage = $"<Parcel>{message}</Parcel>";
            packageSender.SendPackage(packedMessage, address);
        }
    }

    /// <summary>
    /// And again same, now for big packages.
    /// </summary>
    public class PaletPackage : Package
    {
        public override void SendPackage()
        {
            var packedMessage = $"<Palet>{message}</Palet>";
            packageSender.SendPackage(packedMessage, address);
        }
    }

    /// SUMMARY:
    /// Imagine how many class it would take to map all pairs without "Bridge", so:
    /// 1. LetterByDHL
    /// 2. LetterByFEDEX
    /// 3. ParcelByDHL
    /// 4. ParcelByFEDEX
    /// 5. PaletByDHL 
    /// 6. PaletByFEDEX
    /// 
    /// Each future transport company, as well as each future package type
    /// increases this number by a few.
    /// With bridge, now when adding new transport company we don't need to add anything more.
    /// Also when adding new package type, we don't need any additionanl classes.


}
