namespace AutomatedTellerMachine.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class TransferViewModel
    {
        // Der Kontext wurde für die Verwendung einer TransferViewModel-Verbindungszeichenfolge aus der 
        // Konfigurationsdatei ('App.config' oder 'Web.config') der Anwendung konfiguriert. Diese Verbindungszeichenfolge hat standardmäßig die 
        // Datenbank 'AutomatedTellerMachine.Models.TransferViewModel' auf der LocalDb-Instanz als Ziel. 
        // 
        // Wenn Sie eine andere Datenbank und/oder einen anderen Anbieter als Ziel verwenden möchten, ändern Sie die TransferViewModel-Zeichenfolge 
        // in der Anwendungskonfigurationsdatei.
        public TransferViewModel()
          
        {
        }

        public int Id { get; set; }

        // Fügen Sie ein 'DbSet' für jeden Entitätstyp hinzu, den Sie in das Modell einschließen möchten. Weitere Informationen 
        // zum Konfigurieren und Verwenden eines Code First-Modells finden Sie unter 'http://go.microsoft.com/fwlink/?LinkId=390109'.

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount { get; set; }

        [Required]
        [Display(Name = "To Account#")]
        public string DestinationCheckingAccountNumber { get; set; }

        [Required]

        public int CheckingAccountId { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}