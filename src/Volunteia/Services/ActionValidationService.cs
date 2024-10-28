
using Volunteia.Models;
using System.Text;
using System.Text.Json;

public class ActionService
{

    private readonly UserAction _useraction;
    private readonly HttpClient _httpClient;

    public ActionService(UserAction useraction, HttpClient httpClient)
    {

        _useraction = useraction;
        _httpClient = httpClient;
    }

    public async Task<string> PublishActionAsync(string Name, string ActionBio)
    {

        string prompt = $"O seguinte título e/ou descrição deve ter status 'negligible' ou 'low' dentro das safety ratings do Gemini. Responda APENAS com 'Aprovado' (sem aspas) caso passe no teste, ou então 'aguardar moderação'.\n\nTítulo: {Name}\nDescrição: {ActionBio}";

        var url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key=AIzaSyBw82orw2595kKeAHonDT00H1R1eAMrF1c"; // Substitua pelo endpoint da API desejada

        // Cria o JSON diretamente como uma string
        var jsonContent = new StringContent(
           $"{{\"contents\":[{{\"parts\":[{{\"text\":\"{prompt}\"}}]}}]}}",
            Encoding.UTF8,
            "application/json"
        );

        // Envia a solicitação POST
        var response = await _httpClient.PostAsync(url, jsonContent);

        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            // Desserializa o JSON e acessa o campo "text"
            using var document = JsonDocument.Parse(responseBody);

            if (document.RootElement.TryGetProperty("candidates", out var candidatesElement) &&
            candidatesElement.GetArrayLength() > 0 &&
            candidatesElement[0].TryGetProperty("content", out var contentElement) &&
            contentElement.TryGetProperty("parts", out var partsElement) &&
            partsElement.GetArrayLength() > 0 &&
            partsElement[0].TryGetProperty("text", out var textElement))
            {
                // Remove espaços extras e retorna o texto
                return textElement.GetString().Trim();
            }
            return responseBody;
        }
        else
        {
            throw new Exception($"A requisição falhou com o status {response.StatusCode}");
        }
    }
}
