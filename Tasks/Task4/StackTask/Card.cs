namespace StackTask;


public enum CardElement
{
    Water,
    Fire,
    Earth,
    Air,
    Light,
    Darkness

}

public enum CardType
{
    Creature,
    Spell,
    InstallSpell,
    territory
}

public class Card
{

    private string text;
    private int prior;
    private CardElement element;
    private CardType type;
   


    public Card(CardElement elem, CardType type, string text, int prior)
    {
        this.text = text;
        this.prior = prior;
        this.element = elem;
        this.type = type;
    }
    public override string ToString()
    {
        return $"\t\n {element} \n\t {type} \n {text} \n";
    }

    public CardElement Element
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public CardType Type
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public string Text
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public int Prior
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}