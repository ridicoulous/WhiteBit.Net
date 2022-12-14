using CryptoExchange.Net;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using WhiteBit.Net.Clients.Options;

namespace WhiteBit.Net.Clients
{
    public abstract class WhiteBitApiClient : RestApiClient
    {
        protected readonly WhiteBitClient baseClient;

        protected WhiteBitApiClient(string name, WhiteBitClientOptions options, RestApiClientOptions apiOptions, CryptoExchange.Net.Logging.Log log, WhiteBitClient client) : base(log, options, apiOptions)
        {
            ExchangeName = name;
            baseClient = client;
        }
        protected abstract string ApiVersion { get; }
        public string ExchangeName { get; }

        internal Uri GetUrl(string endpoint)
        {
            return new Uri(BaseAddress.AppendPath($"v{ApiVersion}").AppendPath(endpoint));
        }
        /// <summary>
        /// Fill parameters in a path. Parameters are specified by '{}' and should be specified in occuring sequence
        /// </summary>
        /// <param name="path">The total path string</param>
        /// <param name="values">The values to fill</param>
        /// <returns></returns>
        protected static string FillPathParameter(string path, params string[] values)
        {
            foreach (var value in values)
            {
                var indexB = path.IndexOf("{", StringComparison.Ordinal);
                var indexE = path.IndexOf("}", StringComparison.Ordinal);
                if (indexB >= 0 && indexE > indexB)
                {
                    path = path.Remove(indexB, indexE - indexB +1);
                    path = path.Insert(indexB, value);
                }
            }
            return path;
        }
        protected async Task<WebCallResult<T>> SendRequestInternal<T>(
               Uri uri,
               HttpMethod method,
               CancellationToken cancellationToken,
               Dictionary<string, object>? parameters = null,
               bool signed = false,
               HttpMethodParameterPosition? postPosition = null,
               ArrayParametersSerialization? arraySerialization = null,
               int weight = 1
           ) where T : class
        {
            return await base.SendRequestAsync<T>(uri, method, cancellationToken, parameters, signed, postPosition, arraySerialization, requestWeight: weight);
        }
    }
}