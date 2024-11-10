global using System.Linq.Expressions;
global using Application.Abstractions;
global using Application.Contexts;
global using Application.Features.Commands;
global using static Application.Features.Commands.DeleteCategoryCommand;
global using static Application.Features.Commands.PatchCategoryCommand;
global using static Application.Features.Commands.PostCategoryCommand;
global using Application.Features.DomainEvents;
global using Application.Features.Queries;
global using static Application.Features.Queries.GetAllCategoriesQuery;
global using static Application.Features.Queries.GetCategoryQuery;
global using Application.Features.Shared;
global using Application.Repositories;
global using Domain.Cache;
global using Domain.Entities;
global using static Domain.Extensions.Collections.Collections;
global using Domain.Persistence;
global using FluentAssertions;
global using FluentValidation;
global using FluentValidation.Results;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Query;
global using Moq;
global using UnitTests.Shared;