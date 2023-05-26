using System;
using System.Collections.Generic;

public interface IMoneyService
{
	string GetName();

	void Init(string key, Action<bool> callback);

	void Shutdown();

	bool IsInitialized();

	void GetProductData(string[] productIds, Action<List<ProductData>, string> callback);

	void Purchase(string productId, Action<MoneyPurchaseResult, PurchaseData> callback);

	void FinishPurchase(string productId, Action<bool> callback);

	void GetUnfinishedPurchases(Action<List<PurchaseData>> callback);
}
