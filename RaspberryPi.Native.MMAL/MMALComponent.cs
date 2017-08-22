﻿using RaspberryPi.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaspberryPi.MMAL
{
    /// <summary>
    /// MMAL Component
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("MMAL Component: {Name}")]
    public class MMALComponent : IDisposable
    {
        private readonly /*MMAL_COMPONENT_T*/IntPtr m_handle;
        private readonly MMALComponentName m_name;

        internal /*MMAL_COMPONENT_T*/IntPtr Handle { get { return this.m_handle; } }
        public MMALComponentName Name { get { return this.m_name; } }

        internal MMALComponent(/*MMAL_COMPONENT_T*/IntPtr handle, MMALComponentName name)
        {
            this.m_handle = handle;
            this.m_name = name;
        }

        /// <summary>
        /// Acquire a reference on a component.
        /// Acquiring a reference on a component will prevent a component from being destroyed until
        /// the acquired reference is released(by a call to Dispose).
        /// References are internally counted so all acquired references need a matching call to
        /// release them.
        /// </summary>
        public void Acquire()
        {
            MmalNativeMethods.ComponentAcquire(this.m_handle);
        }

        /// <summary>
        /// Release a reference on a component
        /// Release an acquired reference on a component.Triggers the destruction of the component when
        /// the last reference is being released.
        /// \note This is in fact an alias of \ref mmal_component_destroy which is added to make client
        /// code clearer.
        /// </summary>
        public void Release()
        {
            var status = MmalNativeMethods.ComponentRelease(this.m_handle);
            if (status != MMAL_STATUS_T.MMAL_SUCCESS)
            {
                throw new MMALException(status);
            }
        }

        /// <summary>
        /// Destroy a previously created component
        /// Release an acquired reference on a component. Only actually destroys the component when
        /// the last reference is being released.
        /// </summary>
        public void Dispose()
        {
            MmalNativeMethods.ComponentDestroy(this.m_handle);
        }

        /// <summary>
        /// Enable processing on a component
        /// </summary>
        public void Enable()
        {
            var status = MmalNativeMethods.ComponentEnable(this.m_handle);
            if (status != MMAL_STATUS_T.MMAL_SUCCESS)
            {
                throw new MMALException(status);
            }
        }

        /// <summary>
        /// Disable processing on a component
        /// </summary>
        public void Disable()
        {
            var status = MmalNativeMethods.ComponentDisable(this.m_handle);
            if (status != MMAL_STATUS_T.MMAL_SUCCESS)
            {
                throw new MMALException(status);
            }
        }
    }
}
