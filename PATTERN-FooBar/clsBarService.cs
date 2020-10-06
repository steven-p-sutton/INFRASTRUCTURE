﻿using FooService;

namespace BarService
{
    class clsBarService : IBarService
    {
        private readonly IFooService _fooService;
        public clsBarService(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void DoSomeRealWork()
        {
            for (int i = 0; i < 10; i++)
            {
                _fooService.DoThing(i);
            }
        }
    }
}