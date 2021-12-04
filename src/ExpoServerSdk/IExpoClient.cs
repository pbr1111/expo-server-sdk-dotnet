using ExpoServerSdk.Models;
using System.Threading.Tasks;

namespace ExpoServerSdk;

public interface IExpoClient
{
    Task<PushTicketResponse> PushSendAsync(PushTicketRequest pushTicketRequest);
    Task<PushReceiptResponse> PushGetReceiptsAsync(PushReceiptRequest pushReceiptRequest);
    Task<U> PostAsync<T, U>(T request, string path);
}
