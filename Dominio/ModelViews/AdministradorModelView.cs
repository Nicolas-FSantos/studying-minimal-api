using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradoreModelView
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;
}