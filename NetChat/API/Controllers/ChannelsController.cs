using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/channels")]
    public class ChannelsController : ControllerBase
    {
        private DataContext _context;
        private ILogger<ChannelsController> _logger;

        public ChannelsController(DataContext context, ILogger<ChannelsController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<IActionResult> Get()
        {
            Task<IEnumerable<Domain.Channel>> channelTask = GetChannels();

            _logger.LogInformation("Siguiente tarea");

            var channels = await channelTask;
            _logger.LogInformation("Termino la tarea");

            return Ok(channels);
        }

        private async Task<IEnumerable<Domain.Channel>> GetChannels()
        {
            var channels = await _context.Channels.ToListAsync();
            await Task.Delay(20000);
            return channels;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var channel = _context.Channels.FirstOrDefault(x => x.Id == id);
            return Ok(channel);
        }

    }
}