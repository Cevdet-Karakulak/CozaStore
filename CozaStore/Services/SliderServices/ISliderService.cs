﻿using CozaStore.Dtos.SliderDTOs;

namespace CozaStore.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetSliderDto> GetSliderByIdAsync(string id);
    }
}
