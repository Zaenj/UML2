
namespace BigmommasPizzaa;
public class Kunde
{
    #region Instance field
    private string _nameCustomer;
    private string _adresseCustomer;
    private string _emailCustomer;
    private string _telefonCustomer;
    private int _ISBN;
#endregion

    #region Constructor
    public Kunde(string name, string adresse, string email, string telefon, int iSBN)
    {
        _nameCustomer = name;
        _adresseCustomer = adresse;
        _emailCustomer = email;
        _telefonCustomer = telefon;
        _ISBN = iSBN;
    }
    #endregion

    #region Properties
    //public string nameCustomer { get; set; }
    //public string adresseCustomer { get; set; }
    //public string emailCustomer { get; set; }
    //public string telefonCustomer { get; set; }
    //public int ISBN { get; set; }

    #endregion

    public string nameCustomer
    {
        get { return _nameCustomer; }
        set { _nameCustomer = value; }
    }
    public string adresseCustomer
    {
        get { return _adresseCustomer; }
        set { _adresseCustomer = value; }

    }
    public string emailCustomer
    {
        get { return _emailCustomer; }
        set { _emailCustomer = value; }
    }
    public string telefonCustomer
    {
        get { return _telefonCustomer; }
        set { _telefonCustomer = value; }
    }
   
    public int ISBN
    {
        get { return _ISBN; }
        set { }
    }

    public override string ToString()
    {
        return $"{{{nameof(nameCustomer)} = {nameCustomer}, {nameof(adresseCustomer)} = {adresseCustomer}, {nameof(emailCustomer)} = {emailCustomer}, {nameof(telefonCustomer)} = {telefonCustomer}, {nameof(ISBN)} = {ISBN.ToString()}}}";
    }







    //public override string ToString()
    //{
    //    return $"{{{nameof(nameCustomer)}={nameCustomer}, {nameof(adresseCustomer)}={adresseCustomer}, {nameof(emailCustomer)}={emailCustomer}, {nameof(telefonCustomer)}={telefonCustomer}, {nameof(ISBN)}={ISBN.ToString()}, {nameof(name)}={name}, {nameof(email)}={email}, {nameof(telefon)}={telefon}, {nameof(adresse)}={adresse}, {nameof(isbn)}={isbn.ToString()}}}";
    //}
}
