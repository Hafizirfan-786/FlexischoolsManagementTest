using FlexischoolsManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.Contract
{
    public interface ILectureTheatreService
    {
        Task<LectureTheatreDto> AddAsync(LectureTheatreAdditionDto LectureTheatreForCreationDto, CancellationToken cancellationToken = default);

        Task<IEnumerable<LectureTheatreDto>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<LectureTheatreDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
