[TestMethod]

        public void Nome_do_metodo_Privado_Erro()

        {

            //Arrange: Set up the test.

                var mock<Objeto> = new mock<Objeto>()

            var parametro_do_metodo_Request = GetObjeto();

 

            //Setup: Mock

            Objeto

                .Setup(x => x.Metodo_do_mock(It.IsAny<tipo_parametro>()))

                .ThrowsAsync(new Exception());

 

            Nome_da_classe nome_da_classe = new Nome_da_classe(paramentros);

 

            //MethodInfo: parameters.

            MethodInfo methodInfo = typeof(Nome_da_classe).GetMethod("Nome_do_metodo", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] parameters = { parametro_do_metodo_Request };

 

            //Act: Execute the test.

            //Assert: Verify the results.

            Assert.ThrowsExceptionAsync<Exception>(() => (Task)methodInfo.Invoke(nome_da_classe, parameters));

        }
