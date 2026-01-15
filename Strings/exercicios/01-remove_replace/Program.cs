namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = input;

            // Your work here

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // Aqui ele faz um calculo para pegar o index do número 5; Posição de onde aparece o <span> + o tamanho dele = index Do 5
            
            int quantityEnd = input.IndexOf(closeSpan); // Pega o index de onde começa a aparecer o </span>;
            
            int quantityLength = quantityEnd - quantityStart; // A quantidade de caracteres que está entre o <span> e </span>
            
            quantity = input.Substring(quantityStart, quantityLength); // Do index 35, pega 5 caracteres e faça uma string = 5000;
            
            quantity = $"Quantity: {quantity}";

            // Trade the Symbol:

            const string tradeSymbol = "&trade;";
            const string regSymbol = "&reg;";
            output = output.Replace(tradeSymbol, regSymbol);

            // Remove div tags:

            const string openDivTag = "<div>";
            int startDivTag = output.IndexOf(openDivTag);
            output = output.Remove(startDivTag, openDivTag.Length);


            const string closeDivTag = "</div>";
            int endDivTag = output.IndexOf(closeDivTag);
            output = output.Remove(endDivTag, closeDivTag.Length);

            output = $"Output: {output}";

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
    }
}
