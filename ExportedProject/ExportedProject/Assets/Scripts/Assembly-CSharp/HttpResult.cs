public enum HttpResult
{
	Unknown = -1,
	NetworkError = 0,
	NoInternet = 1,
	OK = 200,
	Created = 201,
	NoContent = 204,
	NotModified = 304,
	InvalidParameters = 400,
	Unauthorized = 401,
	Forbidden = 403,
	NotFound = 404,
	Teapot = 418,
	InternalServerError = 503
}
