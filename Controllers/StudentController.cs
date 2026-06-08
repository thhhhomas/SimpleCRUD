using Microsoft.AspNetCore.Mvc;
using SOGSA.Api.Dtos;
using SOGSA.Api.Services;

namespace SOGSA.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController(IStudentService _service) : ControllerBase {

  [HttpGet("{id}")]
  public async Task<ActionResult<StudentResponse>> GetStudent(long id) {
    var student = await _service.GetStudentByIdAsync(id);
    return  student is null ? NotFound("Student with the given Id was not found.") : Ok(student);
  }

  [HttpGet]
  public async Task<ActionResult<IReadOnlyList<StudentResponse>>> GetStudents()
    => Ok(await _service.GetStudentsAsync());

  [HttpPost]
  public async Task<ActionResult<StudentResponse>> CreateStudent(StudentCreate student) {
    var createdStudent = await _service.CreateStudentAsync(student);
    return CreatedAtAction(nameof(GetStudent), new { id = createdStudent.Id }, createdStudent);
  }

  [HttpPut("{id}")]
  public async Task<ActionResult> UpdateStudent(long id, StudentUpdate student) {
    var isUpdated = await _service.UpdateStudentAsync(id, student);
    return isUpdated ? NoContent() : NotFound("Student with the given Id was not found.");
  }

  [HttpDelete("{id}")]
  public async Task<ActionResult> DeleteStudent(long id) {
    var isDeleted = await _service.DeleteStudentAsync(id);
    return isDeleted ? NoContent() : NotFound("Student with the given Id was not found.");
  }

}
