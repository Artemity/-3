
namespace Lib_13
{
    public class PracticalN3
    {
        public static string QuantityLessAverage(int[,] matr)
        {
            int countElInRow = 0;
            int quantityLessAverage = 0;
            double sum = 0;
            double average;
            string strCountLessAverage = "";

            //������� ���������� �������� � �� �� �����
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {                    
                    countElInRow++;
                    sum += matr[i, j];
                }
            }
            //������� �������������� ���� ��������
            average = sum / countElInRow;
            //������� ���������� ��������� � ������, ������� ������ �������� ���������������
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for(int j = 0;j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] < average)
                        quantityLessAverage++;
                }
                strCountLessAverage += quantityLessAverage.ToString() + " ";
                quantityLessAverage = 0;
            }
            strCountLessAverage.Remove(strCountLessAverage.Length-1);
            return strCountLessAverage;
        }
        int proverkaGit = 512;
    }

}
