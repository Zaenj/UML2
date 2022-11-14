
namespace BigmommasPizzaa;
public class BigMommasPizza
{
    #region
    private string _name;
    private string _adresse;
    private string _email;
    private string _telefon;
#endregion

    #region Constructor
    public BigMommasPizza(string name, string adresse, string email, string telefon)
    {
        _name = name;
        _adresse = adresse;
        _email = email;
        _telefon = telefon;
    }
    #endregion

    #region Properties
    public string name { get; set; }
    public string adresse { get; set; }
    public string email { get; set; }
    public string telefon { get; set; }

    #endregion

    public override string ToString()
    {
        return "Navn: " + _name + "Adresse:" + _adresse + "Email:" + _email + "Telefon" + _telefon;
    }
}
