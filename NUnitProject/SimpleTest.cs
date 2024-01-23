namespace NUnitProject
{   
    public class SimpleTest : PrePostConditionExample  // ���� ������ ���� ����� ����������� �� PrePostConditionExample
    {                                                  //, �� ��������� �������� [OneTimeSetUp],  [SetUp] � �.�.
        /*[Test]  // ���������
        public void Test1()
        {
            Assert.Fail();
        }*/

        [SetUp]  // ����� ����������� ����� ������ �������� �������, ������ ����� �����������
        public void Setup1()
        {
            Console.WriteLine($"{this}: SetUp1...");
        }
        [Test]  // ���������
        public void Test3()
        {
            Console.WriteLine($"{this}: Test3...");   // this - � ����� ������ � ������ ��������
            Assert.Pass();
        }
    }
 
}


// stack trace - ��� � ��� ����� � �����
// ��� ������� ��� - Run ,�� ���������� ��� �����, ���������� ��������� [Test]
// ������ � ���������� [Test] ����� ��������� ���� �� ����������

/*   public class SimpleTest  // ���� ����������� ��� ������������
    {
       //[Test]  // ���������
     //   public void Test1()
      //  {
      //      Assert.Fail();
     //   }

        [Test]  // ���������
        public void Test2()
        {
            Console.WriteLine($"{this}: Test...");   // this - � ����� ������ � ������ ��������
            Assert.Pass();
        }
    }
  */