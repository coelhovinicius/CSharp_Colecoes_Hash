/* >>> STRUCT POINT - TIPO VALOR <<< */
namespace Aula210_ColecoesHash.Entities
{
    struct Point // Tipo Valor
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
