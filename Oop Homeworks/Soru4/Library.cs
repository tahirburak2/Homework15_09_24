using System;

namespace Oop_Homeworks.Soru4;

public class Library : Book
{
    public Library(string title, string author, int pages, int ıSBN) : base(title, author, pages, ıSBN)
    {
    }

    public override void Borrow()
    {
        base.Borrow();
    }

    public override void Return()
    {
        base.Return();
    }
}
