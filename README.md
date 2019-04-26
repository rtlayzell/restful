# Restful MVC

A library of components to simplify the development of Maturity Level 3 REST API's by defining them in a declarative manner.

# Usage

```csharp
[ApiController]
[Route("api/[controller]")]
public class StudentsController : RestController
{
	/// ...

	[HttpGet]
	public async Task<IActionResult> GetStudentsAsync(int offset, int limit)
	{
		var result = await _repository.QueryStudentsAsync(q => q.Page(offset, limit));

		var min = 0;
		var max = result.Total;

		return SingletonResource(new { results.Count, results.Total })
			.Link("find", r => GetStudentByIdAsync(Exp.Var<int>()))
			.Link("next", r => GetStudentsAsync(Math.Min(offset + limit, max), limit), c => c.Condition(r => offset < max))
			.Link("prev", r => GetStudentsAsync(Math.Max(offset - limit, min), limit), c => c.Condition(r => offset > min))
			.Embed("students", () => CollectionResource(result.Data)
				.Link("self", r => GetStudentByIdAsync(r.Id))
				.Link("course", r => GetStudentCourseAsync(r.Id))
				.Link("grades", r => GetStudentGradesAsync(r.Id)));
	}

	/// ...
}

```

```json
// HTTP 1.1 GET
// https://localhost/api/students?limit=10

// Response:
{
	"_links": {
		"self": { "href": "/api/students?limit=10" },
		"find": { "href": "/api/students/{id}", "templated": true },
		"next": { "href": "/api/students?offset=10&limit=10" }
	},
	"_embedded": {
		"students": [{
			"_links": {
				"self": { "href": "/api/students/1" },
				"course": { "href": "/api/students/1/course" },
				"grades": { "href": "/api/students/1/grades" }
			},
			"firstname": "Reegan",
			"lastname": "Layzell"
		}, {
			...
		}]
	},
	"count": 10,
	"total": 271
}
```