namespace Abstraction;

public  class Triangle  // ����� �����
{
    public double Side1;
    public double Side2;
    public double Side3;
    public string resultTr;  // ��� ����������� ���� ������������
    public double resultTri;
    public void TriangleResult() {}
    public virtual void SquareResult(double side1, double side2, double side3) 
    {
        Console.WriteLine($"������� ��������������� ������������ �����: {resultTri}");
    }

    //   public void Pause() {}
    //  public void Deactivate() {}
}

