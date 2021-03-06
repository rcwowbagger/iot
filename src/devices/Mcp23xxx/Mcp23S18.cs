﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Device.Gpio;
using System.Device.Spi;

namespace Iot.Device.Mcp23xxx
{
    /// <summary>
    /// Driver for the Microchip MCP23s18 16-Bit I/O Expander with Open-Drain Outputs.
    /// </summary>
    public class Mcp23s18 : Mcp23x1x
    {
        /// <summary>
        /// Initializes a new instance of the Mcp23s18 device.
        /// </summary>
        /// <param name="spiDevice">The SPI device used for communication.</param>
        /// <param name="reset">
        /// The output pin number that is connected to the hardware reset, if any. If specified the device
        /// will start in a disabled state.
        /// <param name="interruptA">The input pin number that is connected to the interrupt for Port A (INTA), if any.</param>
        /// <param name="interruptB">The input pin number that is connected to the interrupt for Port B (INTB), if any.</param>
        /// <param name="masterController">
        /// The controller for the reset and interrupt pins. If not specified, the default controller will be used.
        /// </param>
        public Mcp23s18(SpiDevice spiDevice, int reset = -1, int interruptA = -1, int interruptB = -1, IGpioController masterController = null)
            : base(new SpiAdapter(spiDevice, 0x20), reset, interruptA, interruptB, masterController)
        {
        }
    }
}
