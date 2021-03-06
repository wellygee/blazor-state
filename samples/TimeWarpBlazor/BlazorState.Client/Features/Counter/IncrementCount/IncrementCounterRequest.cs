﻿namespace BlazorState.Client.Features.Counter.IncrementCount
{
  using MediatR;

  public class IncrementCounterRequest : IRequest<CounterState>
  {
    public int Amount { get; set; }
  }
}