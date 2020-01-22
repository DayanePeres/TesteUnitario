using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Demo;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact] //fato, o que não vai mudar
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado); //usar equals para comparar coisas iguais é melhor pois a mensagem é mias clara no erro
        }

        [Theory] //ideia de uma teoria. Para testar mais situações. 
        [InlineData(1, 1, 2)] // para passar os valores. Não importa o tipo de dado, ele é referente deacordo com a assinatura do método
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(3, 2, 5)]
        [InlineData(5, 5, 10)]
        [InlineData(4, 8, 12)]

        public void Calculadora_Somar_RetornarnaValoresSomaCorretos(double v1, double v2, double total) 
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
