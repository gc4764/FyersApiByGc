using FyersApiClient.Request;
using GCLibrary.Http;

namespace FyersApiClient
{
    public class FyersV2(string base_address, string client_id, string app_secret, string pin, int time_out)
    {
        public string BaseAddress { get; set; } = base_address;
        public string ClientId { get; set; } = client_id;
        public string AppSecret { get; set; } = app_secret;
        public string Pin { get; set; } = pin;
        public int TimeOut { get; set; } = time_out;


        public string AuthCode { get; set; }
        public string? AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public string AppIdHash { get; set; } = "19ce8fadfc4d2218dba5d0c7ac988bdfc228e346cd79c1df9b124182aa0c2c1e";





        //limit
        public async Task<string?> PlaceLimitSellOrder(string symbol,
        int qty,

        string productType,
        decimal limitPrice,
        string validity,

        decimal stopLoss,
        decimal takeProfit,
        bool offlineOrder,
        int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.LimitOrder,
                side = (int)OrderSide.Sell,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = 0,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> PlaceLimitSBuyOrder(string symbol,
           int qty,

           string productType,
           decimal limitPrice,
           string validity,

           decimal stopLoss,
           decimal takeProfit,
           bool offlineOrder,
           int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.LimitOrder,
                side = (int)OrderSide.Buy,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = 0,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        // market

        public async Task<string?> PlaceMarketSellOrder(string symbol,
        int qty,

        string productType,
        string validity,

        decimal stopLoss,
        decimal takeProfit,
        bool offlineOrder,
        int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.MarketOrder,
                side = (int)OrderSide.Sell,

                productType = productType,
                limitPrice = 0,
                stopPrice = 0,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> PlaceMarketBuyOrder(string symbol,
           int qty,

           string productType,
           string validity,

           decimal stopLoss,
           decimal takeProfit,
           bool offlineOrder,
           int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            // Dictionary<string, string> headers = AuthHeader();
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.MarketOrder,
                side = (int)OrderSide.Buy,

                productType = productType,
                limitPrice = 0,
                stopPrice = 0,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        // stop market

        public async Task<string?> PlaceStopMarketSellOrder(string symbol,
        int qty,

        string productType,
        decimal stopPrice,
        string validity,

        decimal stopLoss,
        decimal takeProfit,
        bool offlineOrder,
        int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.StopLossMarketOrder,
                side = (int)OrderSide.Sell,

                productType = productType,
                limitPrice = 0,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> PlaceStopMarketBuyOrder(string symbol,
           int qty,

           string productType,
           decimal stopPrice,
           string validity,

           decimal stopLoss,
           decimal takeProfit,
           bool offlineOrder,
           int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.StopLossMarketOrder,
                side = (int)OrderSide.Buy,

                productType = productType,
                limitPrice = 0,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        // stop loss limit

        public async Task<string?> PlaceStopLimitSellOrder(string symbol,
        int qty,

        string productType,
        decimal limitPrice,
        decimal stopPrice,
        string validity,

        decimal stopLoss,
        decimal takeProfit,
        bool offlineOrder,
        int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.StopLossLimitOrder,
                side = (int)OrderSide.Sell,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> PlaceStopLimitBuyOrder(string symbol,
           int qty,

           string productType,
           decimal limitPrice,
           decimal stopPrice,
           string validity,

           decimal stopLoss,
           decimal takeProfit,
           bool offlineOrder,
           int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = (int)OrderType.StopLossLimitOrder,
                side = (int)OrderSide.Buy,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }






        public async Task<string?> PlaceSellOrder(string symbol,
          int qty,
          int type,

          string productType,
          decimal limitPrice,
          decimal stopPrice,
          string validity,

          decimal stopLoss,
          decimal takeProfit,
          bool offlineOrder,
          int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = type,
                side = (int)OrderSide.Sell,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> PlaceBuyOrder(string symbol,
           int qty,
           int type,

           string productType,
           decimal limitPrice,
           decimal stopPrice,
           string validity,

           decimal stopLoss,
           decimal takeProfit,
           bool offlineOrder,
           int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = type,
                side = (int)OrderSide.Buy,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }

        public async Task<string?> ModifyOrder(ModifyOrderRequest data_object)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.PatchByGcAsync(Routes.orders, null, headers, data_object);


            return result;
        }

        public async Task<string?> ModifyOrder(string id,
          int qty,
          int type,
          int side,

          decimal limitPrice,
          decimal stopPrice
            )
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            ModifyOrderRequest data = new()
            {
                id = id,
                qty = qty,
                type = type,
                side = side,

                limitPrice = limitPrice,
                stopPrice = stopPrice,

            };

            var result = await request.PatchByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> CancellOrder(string id)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            CancellOrderRequest data = new()
            {
                id = id,

            };

            var result = await request.DeleteByGcAsync(Routes.orders, null, headers, data);


            return result;
        }


        public async Task<string?> ExitAllOpenPosition()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {
                exit_all = 1
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }


        public async Task<string?> ExitPositionBySymbolId(string exchange, string symbol, string series, ProductType type)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {
                id = $"{exchange.ToUpper()}:{symbol.ToUpper()}-{series.ToUpper()}-{type}"
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }


        public async Task<string?> ExitPositionByProductType(List<string> productTypes)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {

                productType = productTypes,
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }

        public async Task<string?> ExitPositionBySegments(List<int> segments)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {
                segment = segments
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }

        public async Task<string?> ExitPositionBySides(List<int> sides)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {
                side = sides,
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }

        public async Task<string?> ExitPositionBySegmentsSidesAndProductType(List<int> segments, List<int> sides, List<string> types)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var data_object = new
            {
                segment = segments,
                side = sides,
                productType = types,
            };

            var result = await request.DeleteByGcAsync(Routes.positions, null, headers, data_object);


            return result;
        }

        public async Task<string?> CancellOrder(CancellOrderRequest data_object)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };


            var result = await request.DeleteByGcAsync(Routes.orders, null, headers, data_object);


            return result;
        }

        public async Task<string?> PlaceOrder(string symbol,
            int qty,
            int type,
            int side,

            string productType,
            decimal limitPrice,
            decimal stopPrice,
            string validity,

            decimal stopLoss,
            decimal takeProfit,
            bool offlineOrder,
            int disclosedQty)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            OrderRequest data = new()
            {
                symbol = symbol,
                qty = qty,
                type = type,
                side = side,

                productType = productType,
                limitPrice = limitPrice,
                stopPrice = stopPrice,
                stopLoss = stopLoss,

                takeProfit = takeProfit,
                offlineOrder = offlineOrder,
                disclosedQty = disclosedQty,
                validity = validity
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data);


            return result;
        }

        public async Task<string?> PlaceOrder(OrderRequest data_object)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.PostByGcAsync(Routes.orders, null, headers, data_object);


            return result;
        }

        /*
         * Multi Order
         * Not working 
         * 
         * public async Task<string?> PlaceOrder(List<OrderRequest> list_of_data_object)
          {
              HttpRequest request = new(BaseAddress, TimeOut);
              // Dictionary<string, string> headers = AuthHeader();
              Dictionary<string, string> headers = new()
              {
                  { "Authorization", $"{ClientId}:{AccessToken}" }
              };

              *//*   string authheader = $"{ClientId}:{AccessToken}";*//*

              var result = await request.PostByGcAsync(EndPoints.orders, null, headers, list_of_data_object);


              return result;
          }
  */
        public async Task<string?> TradeBookByTag(string orderTag)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            Dictionary<string, string> url_parameter = new()
            {
                {"id", $"1:{orderTag}"}
            };

            var result = await request.GetByGcAsync(Routes.tradebook, url_parameter, headers);


            return result;
        }

        public async Task<string?> TradeBook()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.GetByGcAsync(Routes.tradebook, null, headers);


            return result;
        }

        public async Task<string?> Positions()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.GetByGcAsync(Routes.positions, null, headers);


            return result;
        }

        /*        public  async Task<string?> OrderBookByTag(string OrderTag);
        */

        public async Task<string?> OrderBook(string orderId)
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            Dictionary<string, string> url_parameter = new()
            {
                {"id", orderId}
            };

            var result = await request.GetByGcAsync(Routes.orderbook, url_parameter, headers);


            return result;
        }
        public async Task<string?> OrderBook()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            // Dictionary<string, string> headers = AuthHeader();
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            }

            var result = await request.GetByGcAsync(Routes.orderbook, null, headers);


            return result;
        }

        public async Task<string?> Holdings()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.GetByGcAsync(Routes.holdings, null, headers);


            return result;
        }

        public async Task<string?> Funds()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };

            var result = await request.GetByGcAsync(Routes.funds, null, headers);


            return result;
        }


        public async Task<string?> Profile()
        {
            HttpRequest request = new(BaseAddress, TimeOut);
            Dictionary<string, string> headers = new()
            {
                { "Authorization", $"{ClientId}:{AccessToken}" }
            };
            var result = await request.GetByGcAsync(Routes.profile, null, headers);


            return result;
        }

        private Dictionary<string, string> AuthHeader()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"{ClientId}:{AccessToken}");
            return headers;
        }

        public string GetLoginUrl()
        {
            string baseurl = "https://api-t1.fyers.in/api/v3/";
            string redirect_uri = "https://trade.fyers.in/api-login/redirect-uri/index.html";
            string result = $"{baseurl}generate-authcode?client_id={ClientId}&redirect_uri={redirect_uri}&response_type=code&state=sample_state";


            return result;
        }
        /*     public  async Task<string?> GetAccessToeknFromRefershTokenAsync( string referesh_token)
             {
                 HttpRequest request = new(BaseAddress, TimeOut);

                 string? result;

                 ValidateRefreshTokenRequest validateRefeshTokenRequest = new ValidateRefreshTokenRequest();
                 validateRefeshTokenRequest.appIdHash = Utils.AppIdHash(ClientId, AppSecret);
                 validateRefeshTokenRequest.refresh_token = referesh_token;
                 validateRefeshTokenRequest.pin = Pin;


                 string data = JsonSerializer.Serialize<ValidateRefreshTokenRequest>(validateRefeshTokenRequest);

                 result = await request.PostByGcAsync(EndPoints.validate_refresh_token, null, null, data);

                 return result;
             }*/

        public async Task<string?> GetAccessTokenFromAuthCodeAsync()
        {
            HttpRequest request = new(BaseAddress, TimeOut);

            string? result;

            ValidateAuthcodeRequest validateAuthcodeRequest = new()
            {
                code = AuthCode,
                appIdHash = AppIdHash
            };

            result = await request.PostByGcAsync(Routes.validate_authcode, null, null, validateAuthcodeRequest);

            return result;
        }
    }
}
