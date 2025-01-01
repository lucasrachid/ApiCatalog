using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalog.Infrastructure.Data.Context.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Description", "ImageUrl", "CreatedAt" },
                values: new object[,]
                {
                    { "1c33b43a-d83c-42b2-a2cd-495ebfcf921b", "Bebidas", "Categoria de bebidas em geral", "https://example.com/images/bebidas.jpg", DateTime.UtcNow },
                    { "a0697393-7501-4954-8223-2afe24bbd825", "Alimentos", "Categoria de alimentos variados", "https://example.com/images/alimentos.jpg", DateTime.UtcNow },
                    { "3bdf4353-921a-471f-9d41-4e1a5b85402a", "Eletrônicos", "Categoria de produtos eletrônicos", "https://example.com/images/eletronicos.jpg", DateTime.UtcNow },
                    { "6864e892-4f14-4be8-bd10-6f464c6cd107", "Esportes", "Categoria de produtos esportivos", "https://example.com/images/esportes.jpg", DateTime.UtcNow },
                    { "1e6073fc-c6f1-4802-8b68-fa88c25b5f3a", "Livros", "Categoria de livros e material didático", "https://example.com/images/livros.jpg", DateTime.UtcNow },
                    { "aa800b57-4e8b-47e7-9bec-fc1a7217ea04", "Móveis", "Categoria de móveis para casa e escritório", "https://example.com/images/moveis.jpg", DateTime.UtcNow },
                    { "b3ab622f-c0fe-4b87-bc52-c0d042b5919a", "Moda", "Categoria de roupas e acessórios", "https://example.com/images/moda.jpg", DateTime.UtcNow },
                    { "0032b31e-4961-47ef-8f4e-61e40cec432f", "Saúde", "Categoria de produtos para saúde e bem-estar", "https://example.com/images/saude.jpg", DateTime.UtcNow },
                    { "61c79156-0505-42b5-aa0d-c11e3c720dc1", "Automotivo", "Categoria de produtos para veículos", "https://example.com/images/automotivo.jpg", DateTime.UtcNow },
                    { "4404d59b-4911-4327-8328-1c95d05813d8", "Tecnologia", "Categoria de produtos tecnológicos", "https://example.com/images/tecnologia.jpg", DateTime.UtcNow }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValues: new object[]
                {
                    Guid.Parse("0032b31e-4961-47ef-8f4e-61e40cec432f"),
                    Guid.Parse("1c33b43a-d83c-42b2-a2cd-495ebfcf921b"),
                    Guid.Parse("1e6073fc-c6f1-4802-8b68-fa88c25b5f3a"),
                    Guid.Parse("3bdf4353-921a-471f-9d41-4e1a5b85402a"),
                    Guid.Parse("4404d59b-4911-4327-8328-1c95d05813d8"),
                    Guid.Parse("61c79156-0505-42b5-aa0d-c11e3c720dc1"),
                    Guid.Parse("6864e892-4f14-4be8-bd10-6f464c6cd107"),
                    Guid.Parse("a0697393-7501-4954-8223-2afe24bbd825"),
                    Guid.Parse("aa800b57-4e8b-47e7-9bec-fc1a7217ea04"),
                    Guid.Parse("b3ab622f-c0fe-4b87-bc52-c0d042b5919a")
                });
        }
    }
}
