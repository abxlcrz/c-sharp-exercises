using System;
using Xunit;



namespace newprogram.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GivenTwoNumbersEquals_Dividir_ShouldReturnOne()
        {
            var dividir =new Division();

            var resultado= dividir.Dividir (1,1); 
            Assert.True(resultado==1);
        }

         [Fact]
        public void GivenOneAndTwo_Dividir_ShouldReturnCorrectValue()
        {
            var dividir =new Division();

            var resultado= dividir.Dividir (1,2); 
            Assert.Equal(0.5,resultado);
        }

          [Fact]
        public void GivenANumbreAndZero_Dividir_ShouldReturnCeroException()
        {
            var dividir =new Division();
            try
            {
                var resultado= dividir.Dividir (1,0); 
                Assert.False();
            } catch(NotDivisionCeroException ex)
                {
                    Assert.Equal("NO", ex.Message);

                } catch(Exception)
                
                {
                    Assert.True(false);
                }
                

        }
        
    }
}
