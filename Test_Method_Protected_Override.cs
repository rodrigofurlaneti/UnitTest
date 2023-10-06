        [TestMethod]

        public void Nome_do_metodo_Tipo_Protegido_Substituição_Sucesso()

        {

            //Arrange: Set up the test.

            var nome_da_classe = new Nome_da_classe();

           

                //MethodInfo

                var methodInfo = typeof(RecusaSolicitacaoBeneficioVoucherMobilidadeRequestValidator).GetMethod("PreValidate",

                BindingFlags.NonPublic | BindingFlags.Instance);

            object[] parameters = { parametro_do_metodo };

 

            //Act: Execute the test.

            var result = methodInfo.Invoke(nome_da_classe, parameters);

 

            //Assert: Verify the results.

            Assert.IsNotNull(result);

            Assert.IsTrue((bool)result);

        }
