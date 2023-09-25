namespace StatusCodes.Objects.Project;

public record HttpResponseBase(int StatusCode);

// 1xx: Informational
public record ContinueResponse() : HttpResponseBase(100);
public record SwitchingProtocolsResponse() : HttpResponseBase(101);
public record ProcessingResponse() : HttpResponseBase(102);
public record EarlyHintsResponse() : HttpResponseBase(103);

// 2xx: Successful
public record OkResponse() : HttpResponseBase(200);
public record CreatedResponse() : HttpResponseBase(201);
public record AcceptedResponse() : HttpResponseBase(202);
public record NonAuthoritativeInformationResponse() : HttpResponseBase(203);
public record NoContentResponse() : HttpResponseBase(204);
public record ResetContentResponse() : HttpResponseBase(205);
public record PartialContentResponse() : HttpResponseBase(206);
public record MultiStatusResponse() : HttpResponseBase(207);
public record AlreadyReportedResponse() : HttpResponseBase(208);
public record IMUsedResponse() : HttpResponseBase(226);

// 3xx: Redirection
public record MultipleChoicesResponse() : HttpResponseBase(300);
public record MovedPermanentlyResponse() : HttpResponseBase(301);
public record FoundResponse() : HttpResponseBase(302);
public record SeeOtherResponse() : HttpResponseBase(303);
public record NotModifiedResponse() : HttpResponseBase(304);
public record UseProxyResponse() : HttpResponseBase(305);
public record TemporaryRedirectResponse() : HttpResponseBase(307);
public record PermanentRedirectResponse() : HttpResponseBase(308);

// 4xx: Client Errors
public record BadRequestResponse() : HttpResponseBase(400);
public record UnauthorizedResponse() : HttpResponseBase(401);
public record PaymentRequiredResponse() : HttpResponseBase(402);
public record ForbiddenResponse() : HttpResponseBase(403);
public record NotFoundResponse() : HttpResponseBase(404);
public record MethodNotAllowedResponse() : HttpResponseBase(405);
public record NotAcceptableResponse() : HttpResponseBase(406);
public record ProxyAuthenticationRequiredResponse() : HttpResponseBase(407);
public record RequestTimeoutResponse() : HttpResponseBase(408);
public record ConflictResponse() : HttpResponseBase(409);
public record GoneResponse() : HttpResponseBase(410);
public record LengthRequiredResponse() : HttpResponseBase(411);
public record PreconditionFailedResponse() : HttpResponseBase(412);
public record PayloadTooLargeResponse() : HttpResponseBase(413);
public record URITooLongResponse() : HttpResponseBase(414);
public record UnsupportedMediaTypeResponse() : HttpResponseBase(415);
public record RangeNotSatisfiableResponse() : HttpResponseBase(416);
public record ExpectationFailedResponse() : HttpResponseBase(417);
public record ImATeapotResponse() : HttpResponseBase(418);
public record MisdirectedRequestResponse() : HttpResponseBase(421);
public record UnprocessableEntityResponse() : HttpResponseBase(422);
public record LockedResponse() : HttpResponseBase(423);
public record FailedDependencyResponse() : HttpResponseBase(424);
public record TooEarlyResponse() : HttpResponseBase(425);
public record UpgradeRequiredResponse() : HttpResponseBase(426);
public record PreconditionRequiredResponse() : HttpResponseBase(428);
public record TooManyRequestsResponse() : HttpResponseBase(429);
public record RequestHeaderFieldsTooLargeResponse() : HttpResponseBase(431);
public record UnavailableForLegalReasonsResponse() : HttpResponseBase(451);

// 5xx: Server Errors
public record InternalServerErrorResponse() : HttpResponseBase(500);
public record NotImplementedResponse() : HttpResponseBase(501);
public record BadGatewayResponse() : HttpResponseBase(502);
public record ServiceUnavailableResponse() : HttpResponseBase(503);
public record GatewayTimeoutResponse() : HttpResponseBase(504);
public record HTTPVersionNotSupportedResponse() : HttpResponseBase(505);
public record VariantAlsoNegotiatesResponse() : HttpResponseBase(506);
public record InsufficientStorageResponse() : HttpResponseBase(507);
public record LoopDetectedResponse() : HttpResponseBase(508);
public record NotExtendedResponse() : HttpResponseBase(510);
public record NetworkAuthenticationRequiredResponse() : HttpResponseBase(511);