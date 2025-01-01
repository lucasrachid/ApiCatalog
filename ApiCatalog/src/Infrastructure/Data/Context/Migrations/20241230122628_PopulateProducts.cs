using Microsoft.EntityFrameworkCore.Migrations;
using ApiCatalog.Infrastructure.Data.Context;

#nullable disable

namespace ApiCatalog.Infrastructure.Data.Context.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Id", "Name", "Description", "Price", "ImageUrl", "Stock", "CreatedAt", "CategoryId" },
            values: new object[,]
            {
                // Produtos para a categoria "Bebidas"
                { Guid.NewGuid(), "Coca-Cola", "Refrigerante de cola 350ml", 5.99m, "https://example.com/images/coca-cola.jpg", 100, DateTime.UtcNow, Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b") },
                { Guid.NewGuid(), "Suco de Laranja", "Suco natural de laranja 1L", 7.50m, "https://example.com/images/suco-laranja.jpg", 80, DateTime.UtcNow, Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b") },
                { Guid.NewGuid(), "Água Mineral", "Água mineral 500ml", 2.50m, "https://example.com/images/agua.jpg", 200, DateTime.UtcNow, Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b") },
                { Guid.NewGuid(), "Chá Verde", "Chá verde gelado 1L", 6.99m, "https://example.com/images/cha-verde.jpg", 60, DateTime.UtcNow, Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b") },
                { Guid.NewGuid(), "Cerveja Lager", "Cerveja lager 350ml", 4.99m, "https://example.com/images/cerveja.jpg", 150, DateTime.UtcNow, Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b") },

                // Produtos para a categoria "Alimentos"
                { Guid.NewGuid(), "Arroz", "Arroz branco tipo 1, 5kg", 20.00m, "https://example.com/images/arroz.jpg", 50, DateTime.UtcNow, Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825") },
                { Guid.NewGuid(), "Feijão", "Feijão carioca tipo 1, 1kg", 8.00m, "https://example.com/images/feijao.jpg", 80, DateTime.UtcNow, Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825") },
                { Guid.NewGuid(), "Macarrão", "Macarrão espaguete 500g", 4.50m, "https://example.com/images/macarrao.jpg", 100, DateTime.UtcNow, Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825") },
                { Guid.NewGuid(), "Óleo de Soja", "Óleo de soja 900ml", 9.00m, "https://example.com/images/oleo.jpg", 70, DateTime.UtcNow, Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825") },
                { Guid.NewGuid(), "Sal", "Sal refinado, 1kg", 2.50m, "https://example.com/images/sal.jpg", 200, DateTime.UtcNow, Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825") },

                // Produtos para a categoria "Eletrônicos"
                { Guid.NewGuid(), "Smartphone", "Smartphone 64GB Android", 1500.00m, "https://example.com/images/smartphone.jpg", 30, DateTime.UtcNow, Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a") },
                { Guid.NewGuid(), "Televisão 4K", "TV 50 polegadas 4K", 2500.00m, "https://example.com/images/tv.jpg", 15, DateTime.UtcNow, Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a") },
                { Guid.NewGuid(), "Notebook", "Notebook Intel i5, 8GB RAM", 3500.00m, "https://example.com/images/notebook.jpg", 20, DateTime.UtcNow, Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a") },
                { Guid.NewGuid(), "Fone Bluetooth", "Fone de ouvido Bluetooth", 250.00m, "https://example.com/images/fone.jpg", 100, DateTime.UtcNow, Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a") },
                { Guid.NewGuid(), "Câmera DSLR", "Câmera fotográfica DSLR", 5000.00m, "https://example.com/images/camera.jpg", 10, DateTime.UtcNow, Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a") },
                
                // Produtos para categoria: "Livros"
                { Guid.NewGuid(), "Livro de Fantasia", "Livro de aventuras épicas", 40.00m, "https://example.com/images/livro-fantasia.jpg", 30, DateTime.UtcNow, Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a") },
                { Guid.NewGuid(), "Livro de Romance", "História romântica", 35.00m, "https://example.com/images/livro-romance.jpg", 50, DateTime.UtcNow, Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a") },
                { Guid.NewGuid(), "Livro de História", "História antiga", 45.00m, "https://example.com/images/livro-historia.jpg", 20, DateTime.UtcNow, Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a") },
                { Guid.NewGuid(), "Livro Infantil", "Livro para crianças", 25.00m, "https://example.com/images/livro-infantil.jpg", 70, DateTime.UtcNow, Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a") },
                { Guid.NewGuid(), "Livro Técnico", "Livro de programação", 100.00m, "https://example.com/images/livro-tecnico.jpg", 15, DateTime.UtcNow, Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a") },

                // Produtos para categoria: "Esportes" 
                { Guid.NewGuid(), "Bola de Futebol", "Bola de futebol oficial tamanho 5", 99.90m, "https://example.com/images/bola-futebol.jpg", 50, DateTime.UtcNow, Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107") },
                { Guid.NewGuid(), "Raquete de Tênis", "Raquete de tênis profissional", 499.90m, "https://example.com/images/raquete-tenis.jpg", 20, DateTime.UtcNow, Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107") },
                { Guid.NewGuid(), "Caneleira", "Caneleira para futebol", 29.90m, "https://example.com/images/caneleira.jpg", 100, DateTime.UtcNow, Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107") },
                { Guid.NewGuid(), "Luvas de Boxe", "Luvas de boxe 12 oz", 199.90m, "https://example.com/images/luvas-boxe.jpg", 30, DateTime.UtcNow, Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107") },
                { Guid.NewGuid(), "Rede de Vôlei", "Rede de vôlei profissional", 299.90m, "https://example.com/images/rede-volei.jpg", 15, DateTime.UtcNow, Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107") },

                // Produtos para categoria: "Móveis" 
                { Guid.NewGuid(), "Sofá 3 Lugares", "Sofá de tecido confortável", 1499.90m, "https://example.com/images/sofa.jpg", 10, DateTime.UtcNow, Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04") },
                { Guid.NewGuid(), "Mesa de Jantar", "Mesa de jantar para 6 pessoas", 1999.90m, "https://example.com/images/mesa.jpg", 5, DateTime.UtcNow, Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04") },
                { Guid.NewGuid(), "Cadeira de Escritório", "Cadeira ergonômica", 699.90m, "https://example.com/images/cadeira-escritorio.jpg", 25, DateTime.UtcNow, Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04") },
                { Guid.NewGuid(), "Cama Queen", "Cama tamanho queen com estrutura de madeira", 2499.90m, "https://example.com/images/cama-queen.jpg", 8, DateTime.UtcNow, Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04") },
                { Guid.NewGuid(), "Estante de Livros", "Estante de livros de madeira", 799.90m, "https://example.com/images/estante.jpg", 15, DateTime.UtcNow, Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04") },
                
                // Produtos para categoria: "Moda"
                { Guid.NewGuid(), "Camiseta Básica", "Camiseta de algodão unissex", 49.90m, "https://example.com/images/camiseta.jpg", 100, DateTime.UtcNow, Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a") },
                { Guid.NewGuid(), "Calça Jeans", "Calça jeans masculina", 129.90m, "https://example.com/images/calca-jeans.jpg", 50, DateTime.UtcNow, Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a") },
                { Guid.NewGuid(), "Tênis Esportivo", "Tênis esportivo unissex", 199.90m, "https://example.com/images/tenis.jpg", 70, DateTime.UtcNow, Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a") },
                { Guid.NewGuid(), "Bolsa Feminina", "Bolsa de couro sintético", 149.90m, "https://example.com/images/bolsa.jpg", 30, DateTime.UtcNow, Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a") },
                { Guid.NewGuid(), "Jaqueta de Couro", "Jaqueta de couro masculina", 299.90m, "https://example.com/images/jaqueta.jpg", 20, DateTime.UtcNow, Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a") },

                // Produtos para categoria: "Saúde"
                { Guid.NewGuid(), "Vitaminas C", "Suplemento alimentar vitamina C 500mg", 29.90m, "https://example.com/images/vitamina-c.jpg", 200, DateTime.UtcNow, Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f") },
                { Guid.NewGuid(), "Termômetro Digital", "Termômetro digital com leitura rápida", 49.90m, "https://example.com/images/termometro.jpg", 100, DateTime.UtcNow, Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f") },
                { Guid.NewGuid(), "Máscara N95", "Máscara de proteção N95 (pacote com 10)", 99.90m, "https://example.com/images/mascara.jpg", 300, DateTime.UtcNow, Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f") },
                { Guid.NewGuid(), "Aparelho de Pressão", "Monitor de pressão arterial automático", 199.90m, "https://example.com/images/aparelho-pressao.jpg", 50, DateTime.UtcNow, Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f") },
                { Guid.NewGuid(), "Nebulizador", "Nebulizador portátil", 249.90m, "https://example.com/images/nebulizador.jpg", 40, DateTime.UtcNow, Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f") },

                // Produtos para categoria: "Automotivo"
                { Guid.NewGuid(), "Óleo para Motor", "Óleo lubrificante sintético 5W-30", 99.90m, "https://example.com/images/oleo-motor.jpg", 100, DateTime.UtcNow, Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1") },
                { Guid.NewGuid(), "Bateria Automotiva", "Bateria automotiva 60Ah", 499.90m, "https://example.com/images/bateria.jpg", 30, DateTime.UtcNow, Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1") },
                { Guid.NewGuid(), "Pneu Aro 15", "Pneu para carro aro 15", 399.90m, "https://example.com/images/pneu.jpg", 50, DateTime.UtcNow, Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1") },
                { Guid.NewGuid(), "Capa de Banco", "Capa de banco automotiva universal", 149.90m, "https://example.com/images/capa-banco.jpg", 70, DateTime.UtcNow, Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1") },
                { Guid.NewGuid(), "Kit Ferramentas", "Kit de ferramentas automotivas com 50 peças", 249.90m, "https://example.com/images/kit-ferramentas.jpg", 40, DateTime.UtcNow, Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1") },
                
                // Produtos para categoria: "Tecnologia"
                { Guid.NewGuid(), "Smartphone X", "Smartphone de última geração com tela AMOLED", 3999.90m, "https://example.com/images/smartphone-x.jpg", 50, DateTime.UtcNow, Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8") },
                { Guid.NewGuid(), "Notebook Pro", "Notebook com processador Intel i7 e 16GB RAM", 6999.90m, "https://example.com/images/notebook-pro.jpg", 30, DateTime.UtcNow, Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8") },
                { Guid.NewGuid(), "Headset Gamer", "Headset gamer com som surround 7.1", 499.90m, "https://example.com/images/headset-gamer.jpg", 100, DateTime.UtcNow, Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8") },
                { Guid.NewGuid(), "Smartwatch Fit", "Smartwatch com monitoramento de saúde", 999.90m, "https://example.com/images/smartwatch-fit.jpg", 70, DateTime.UtcNow, Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8") },
                { Guid.NewGuid(), "Tablet Max", "Tablet com tela de 10.5 polegadas e 64GB", 2999.90m, "https://example.com/images/tablet-max.jpg", 40, DateTime.UtcNow, Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8") }
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
