namespace StackTask;

public class CardStack
{
    private Card[] massiv = new Card[0];
    public int Size
    {
        get
        {
            return massiv.Length;
        }
    }
    public void Push(Card card)
    {

    }

    public Card Top()
    {
        throw new NotImplementedException();
    }

    public Card Pop()
    {
        throw new NotImplementedException();
    }

    public bool IsReadyForGame()
    {
        if (massiv.Length >= 30)
        {
            return true;
        }
        else if (massiv.Length > 100)
        {
            throw new Exception("too much");
        }
        else
        {
            return false;
        }
    }

    public void Shuffle()
    {
        throw new NotImplementedException();
    }
}
