using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminPanel.Data;
using AdminPanel.Dtos;
using AdminPanel.Models;
using System;

namespace AdminPanel.Services
{
    public class MachineService
    {
        private readonly DataContext _context;
        public MachineService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Machine>> GetMachines()
        {
            var machines = await _context.Machines.ToListAsync();
            return machines;
        }

        public async Task<bool> CreateMachine(Machine machine)
        {
            try
            {
                if (await _context.Machines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == machine.DeviceBarcodeNo) != null)
                {
                    return false;
                }
                else
                {
                    await _context.Machines.AddAsync(machine);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CreateMainMachine(MainMachineBindingModel machine)
        {
            try
            {
                if (await _context.MainMachines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == int.Parse(machine.DeviceBarcodeNo)) != null)
                {
                    return false;
                }
                else
                {
                    MainMachine mainMachineToCreate = new MainMachine{
                        DeviceBarcodeNo = int.Parse(machine.DeviceBarcodeNo),
                        MainsActivePower = int.Parse(machine.MainsActivePower),
                        MainsApparentPower = int.Parse(machine.MainsApparentPower),
                        MainsCurrent = int.Parse(machine.MainsCurrent),
                        MainsFrequence = int.Parse(machine.MainsFrequence),
                        MainsReactivePower = int.Parse(machine.MainsReactivePower),
                        MainsVolt = int.Parse(machine.MainsFrequence),
                        MainsDeviceOnOff = machine.MainsDeviceOnOff,
                        MainsBreakerOff = machine.MainsBreakerOff,
                        MainsBreakerOn = machine.MainsBreakerOn,
                        MainsModeManuel = machine.MainsModeManuel,
                        MainsModeSemi = machine.MainsModeSemi,
                        MainsStatusOff = machine.MainsStatusOff,
                        MainsStatusOn = machine.MainsStatusOn,
                        WriteCommand = machine.WriteCommand,
                    };
                    Machine machineToCreate = new Machine{
                        Type = "Main",
                        DeviceBarcodeNo = int.Parse(machine.DeviceBarcodeNo),
                        DeviceOnOff = machine.MainsDeviceOnOff,
                        ActivePower = int.Parse(machine.MainsActivePower),
                        ApparentPower = int.Parse(machine.MainsApparentPower),
                    };
                    await _context.MainMachines.AddAsync(mainMachineToCreate);
                    await _context.Machines.AddAsync(machineToCreate);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

         public async Task<bool> UpdateMainMachine(MainMachineBindingModel machine, int id)
        {
/*             try
            { */
                var mainMachineToUpdate = await _context.MainMachines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == id);
                var machineToUpdate = await _context.Machines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == id);
                if (mainMachineToUpdate == null)
                {
                    Console.WriteLine("sa");
                    return false;
                }
                else
                {
                    mainMachineToUpdate.DeviceBarcodeNo = int.Parse(machine.DeviceBarcodeNo);
                    mainMachineToUpdate.MainsActivePower = int.Parse(machine.MainsActivePower);
                    mainMachineToUpdate.MainsApparentPower = int.Parse(machine.MainsApparentPower);
                    mainMachineToUpdate.MainsCurrent = int.Parse(machine.MainsCurrent);
                    mainMachineToUpdate.MainsFrequence = int.Parse(machine.MainsFrequence);
                    mainMachineToUpdate.MainsReactivePower = int.Parse(machine.MainsReactivePower);
                    mainMachineToUpdate.MainsVolt = int.Parse(machine.MainsFrequence);
                    mainMachineToUpdate.MainsDeviceOnOff = machine.MainsDeviceOnOff;
                    mainMachineToUpdate.MainsBreakerOff = machine.MainsBreakerOff;
                    mainMachineToUpdate.MainsBreakerOn = machine.MainsBreakerOn;
                    mainMachineToUpdate.MainsModeManuel = machine.MainsModeManuel;
                    mainMachineToUpdate.MainsModeSemi = machine.MainsModeSemi;
                    mainMachineToUpdate.MainsStatusOff = machine.MainsStatusOff;
                    mainMachineToUpdate.MainsStatusOn = machine.MainsStatusOn;
                    mainMachineToUpdate.WriteCommand = machine.WriteCommand;
                    mainMachineToUpdate.deviceAdded = int.Parse(machine.deviceAdded);
                    
                    machineToUpdate.DeviceBarcodeNo = int.Parse(machine.DeviceBarcodeNo);
                    machineToUpdate.DeviceOnOff = machine.MainsDeviceOnOff;
                    machineToUpdate.ActivePower = int.Parse(machine.MainsActivePower);
                    machineToUpdate.ApparentPower = int.Parse(machine.MainsApparentPower);
                    
                    await _context.SaveChangesAsync();
                    return true;
                }
/*             }
            catch
            {
                return false;
            } */
        }

        public async Task<MainMachine> GetMainMachine(int machineId)
        {
            var mainMachineToReturn = await _context.MainMachines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == machineId);
            return mainMachineToReturn;
        }

        public async Task<MainMachineBindingModel> GetMainMachineBindingModel(int machineId)
        {
            var mainMachineToReturn = await _context.MainMachines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == machineId);
            MainMachineBindingModel mainMachineToCreate = new MainMachineBindingModel{
                DeviceBarcodeNo = mainMachineToReturn.DeviceBarcodeNo.ToString(),
                MainsActivePower = mainMachineToReturn.MainsActivePower.ToString(),
                MainsApparentPower = mainMachineToReturn.MainsApparentPower.ToString(),
                MainsCurrent = mainMachineToReturn.MainsCurrent.ToString(),
                MainsFrequence = mainMachineToReturn.MainsFrequence.ToString(),
                MainsReactivePower = mainMachineToReturn.MainsFrequence.ToString(),
                MainsVolt = mainMachineToReturn.MainsFrequence.ToString(),
                MainsDeviceOnOff = mainMachineToReturn.MainsDeviceOnOff,
                MainsBreakerOff = mainMachineToReturn.MainsBreakerOff,
                MainsBreakerOn = mainMachineToReturn.MainsBreakerOn,
                MainsModeManuel = mainMachineToReturn.MainsModeManuel,
                MainsModeSemi = mainMachineToReturn.MainsModeSemi,
                MainsStatusOff = mainMachineToReturn.MainsStatusOff,
                MainsStatusOn = mainMachineToReturn.MainsStatusOn,
                WriteCommand = mainMachineToReturn.WriteCommand,
                deviceAdded = mainMachineToReturn.deviceAdded.ToString()
            };
            return mainMachineToCreate;
        }

        public async Task<bool> DeleteMainMachine(int machineId)
        {
            var mainMachineToDelete = await _context.MainMachines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == machineId);
            var machineToDelete = await _context.Machines.FirstOrDefaultAsync(m => m.DeviceBarcodeNo == machineId);
            _context.MainMachines.Remove(mainMachineToDelete);
            _context.Machines.Remove(machineToDelete);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}