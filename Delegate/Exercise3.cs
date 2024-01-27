
using static Delegate.TypeSorting;

namespace Delegate;

public class Exercise3
{
    public delegate int[] SortArray(int[] numbers);

    public SortArray SelectSortMet(TypeSorting array)
    {
        switch (array)
        {
            case TypeSorting.GnomeSort:
                return new SortArray(GnomeSort.Gnome);
            case TypeSorting.InsertionSort:
                return new SortArray(InsertionSort.Insertion);
            default:  throw new ArgumentException("Invalid sort type");
        }
    }
}

