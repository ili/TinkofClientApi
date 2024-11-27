using System;
using System.Collections.Generic;
using System.Text;

namespace TinkoffPaymentClientApi.Commands;
/// <summary>
/// Метод регистрирует QR и возвращает информацию о нем. Должен быть вызван после вызова метода Init
/// </summary>
public class GetQr : BaseCommand {
  internal override string CommandName => "GetQr";
  /// <summary>
  /// Уникальный идентификатор транзакции в системе Т-Кассы
  /// </summary>
  public string PaymentId { get; private set; }
  /// <summary>
  ///Enum: "PAYLOAD" "IMAGE"
  ///Тип возвращаемых данных:
  ///PAYLOAD – В ответе возвращается только Payload(по-умолчанию);
  ///IMAGE – В ответе возвращается SVG изображение QR.
  /// </summary>
  public string? DataType { get; set; } = "PAYLOAD";

  /// <summary>
  /// Конструктор
  /// </summary>
  /// <param name="paymentId">Уникальный идентификатор транзакции в системе Т-Кассы</param>
  /// <param name="dataType">Тип возвращаемых данных</param>
  public GetQr(string paymentId, string? dataType = null) {
    PaymentId = paymentId;
    DataType = dataType;
  }
}
