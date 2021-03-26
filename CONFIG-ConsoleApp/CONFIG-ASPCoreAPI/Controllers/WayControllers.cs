using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Conductus.CONFIG.API
{
    [Route("Way1")]
    [ApiController]
    public class Way1Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way1Controller(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        //public string Get()
        //{
        //    return "Way2 Hello World";
        //}
        public bool Get()
        {
            // The first simple way is to use the GetSection method from the IConfiguration 
            // interface reading parent/child tags like this:

            return bool.Parse(_configuration.GetSection("MySettings").GetSection("Parameters").GetSection("IsProduction").Value);
        }
    }

    [Route("way2")]
    [ApiController]
    public class Way2Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way2Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        //public string Get()
        //{
        //    return "Way2 Hello World";
        //}
        public bool Get()
        {
            // The second way is a little bit better than the first one.Just use the GetValue method 
            // and explicit what type do want to convert it.
            return _configuration.GetSection("MySettings").GetSection("Parameters").GetValue<bool>("IsProduction");
        }
    }

    [Route("way3")]
    [ApiController]
    public class Way3Controller : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public Way3Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        //public string Get()
        //{
        //    return "Way3 Hello World";
        //}
        public bool Get()
        {
            // The third and more elegant way is to write all properties inline and in order, 
            // separated by a colon.
            return _configuration.GetValue<bool>("MySettings:Parameters:IsProduction");
        }
    }

    [Route("way4")]
    [ApiController]
    public class Way4Controller : ControllerBase
    {
        // The fourth way is to connect (like a binding) one class instance to a corresponding
        // tag in the AppSettings.JSON file.
        // Let’s create a class called MySettingsConfiguration with the same properties above 
        // MySettings tag in the AppSettings.JSON file.

        private readonly MySettingsConfiguration _settings;

        public Way4Controller(IConfiguration configuration)
        {
            _settings = new MySettingsConfiguration();
            configuration.GetSection("MySettings").Bind(_settings);
        }

        [HttpGet]
        //public string Get()
        //{
        //    return "Way4 Hello World";
        //}
        public bool Get()
        {
            // Now it’s just to configure the binding between a MySettingsConfiguration instance and 
            // the configuration section using the Bind method, check it out:
            return _settings?.Parameters?.IsProduction ?? false;
        }
    }

    [Route("way5")]
    [ApiController]
    public class Way5Controller : ControllerBase
    {
        // The next way to read the AppSettings.JSON file is by using the IOptions 
        // interface typing MySettingsConfiguration class that we created before.

        private readonly IOptions<MySettingsConfiguration> _configuration;
        public Way5Controller(IOptions<MySettingsConfiguration> configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        //public string Get()
        //{
        //    return "Way5 Hello World";
        //}
        public bool Get()
        {     
            return _configuration.Value?.Parameters?.IsProduction ?? false;
        }
    }

    [Route("way6")]
    [ApiController]
    public class Way6Controller : ControllerBase
    {
        // In my option, the best way to read the AppSettings.JSON file is to injection 
        // the MySettingsConfiguration class that we created before.

        private readonly MySettingsConfiguration _configuration;
        public Way6Controller(
            MySettingsConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        // public string Get()
        // {
        //    return "Way6 Hello World";
        // }
        public bool Get()
        {
            return _configuration.Parameters.IsProduction;
        }
    }
}