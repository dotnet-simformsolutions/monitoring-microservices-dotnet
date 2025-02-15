﻿using NewsLetterReporting.Api.Entities;

namespace NewsLetterReporting.Api.Contracts;

public record ArticleEventResponse
{
	public Guid Id { get; init; }
	public DateTime CreatedOnUtc { get; init; }
	public ArticleEventType EventType { get; init; }
}
