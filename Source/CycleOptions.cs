﻿// <copyright file="CycleOptions.cs" company="Engage Software">
// Engage: Rotator - http://www.engagemodules.com
// Copyright (c) 2004-2009
// by Engage Software ( http://www.engagesoftware.com )
// </copyright>
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

namespace Engage.Dnn.ContentRotator
{
    using System.Diagnostics;
    using System.Web.UI.WebControls;

    /// <summary>
    /// The options and settings to send to the Cycle plugin
    /// </summary>
    public class CycleOptions
    {
        /// <summary>Backing field for <see cref="AutoStop"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool autoStop;

        /// <summary>Backing field for <see cref="AutoStopCount"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int autoStopCount;

        /// <summary>Backing field for <see cref="ContainerHeight"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Unit containerHeight = Unit.Empty;

        /// <summary>Backing field for <see cref="ContainerResize"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool containerResize = true;

        /// <summary>Backing field for <see cref="Continuous"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool continuous;

        /// <summary>Backing field for <see cref="InitialDelay"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int initialDelay;

        /// <summary>Backing field for <see cref="ManuallyTriggeredTransitionSpeed"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int manuallyTriggeredTransitionSpeed;

        /// <summary>Backing field for <see cref="MillisecondsBetweenTransitions"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int millisecondsBetweenTransitions = 4000;

        /// <summary>Backing field for <see cref="NextButton"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nextButton;

        /// <summary>Backing field for <see cref="Nowrap"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool nowrap;

        /// <summary>Backing field for <see cref="PagerContainer"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string pagerContainer;

        /// <summary>Backing field for <see cref="PagerEvent"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string pagerEvent = "click";

        /// <summary>Backing field for <see cref="PauseOnHover"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool pauseOnHover;

        /// <summary>Backing field for <see cref="PauseOnPagerHover"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool pauseOnPagerHover;

        /// <summary>Backing field for <see cref="PreviousButton"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string previousButton;

        /// <summary>Backing field for <see cref="RandomOrder"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool randomOrder;

        /// <summary>Backing field for <see cref="SimultaneousInOutTransitions"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool simultaneousInOutTransitions = true;

        /// <summary>Backing field for <see cref="SlidesFitContainer"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool slidesFitContainer;

        /// <summary>Backing field for <see cref="StartingSlideIndex"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int startingSlideIndex;

        /// <summary>Backing field for <see cref="TransitionEffects"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Effects transitionEffects = Effects.fade;

        /// <summary>Backing field for <see cref="TransitionInSpeed"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int? transitionInSpeed;

        /// <summary>Backing field for <see cref="TransitionOutSpeed"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int? transitionOutSpeed;

        /// <summary>Backing field for <see cref="TransitionSpeed"/></summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int transitionSpeed = 1000;

        /// <summary>Gets or sets a value indicating whether to end slideshow after <see cref="AutoStopCount"/> transitions</summary>
        public bool AutoStop
        {
            [DebuggerStepThrough]
            get
            {
                return this.autoStop;
            }

            [DebuggerStepThrough]
            set
            {
                this.autoStop = value;
            }
        }

        /// <summary>Gets or sets a value indicating the number of transitions to display before stopping when <see cref="AutoStop"/> is <c>true</c></summary>
        public int AutoStopCount
        {
            [DebuggerStepThrough]
            get
            {
                return this.autoStopCount;
            }

            [DebuggerStepThrough]
            set
            {
                this.autoStopCount = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether clearType corrections should be applied (for IE)
        /// </summary>
        /// <value><c>true</c> if clearType corrections should be applied (for IE); otherwise, <c>false</c>.</value>
        public bool ClearType
        {
            get
            {
                return this.transitionEffects == Effects.fade;
            }
        }

        /// <summary>Gets or sets a value indicating container height, defaults to "auto"</summary>
        public Unit ContainerHeight
        {
            [DebuggerStepThrough]
            get
            {
                return this.containerHeight;
            }

            [DebuggerStepThrough]
            set
            {
                this.containerHeight = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to resize the container to fit largest slide</summary>
        public bool ContainerResize
        {
            [DebuggerStepThrough]
            get
            {
                return this.containerResize;
            }

            [DebuggerStepThrough]
            set
            {
                this.containerResize = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to start the next transition immediately after the current one completes</summary>
        public bool Continuous
        {
            [DebuggerStepThrough]
            get
            {
                return this.continuous;
            }

            [DebuggerStepThrough]
            set
            {
                this.continuous = value;
            }
        }

        /// <summary>Gets or sets a value indicating the additional delay (in ms) for the first transition (hint: can be negative)</summary>
        public int InitialDelay
        {
            [DebuggerStepThrough]
            get
            {
                return this.initialDelay;
            }

            [DebuggerStepThrough]
            set
            {
                this.initialDelay = value;
            }
        }

        /// <summary>Gets or sets a value indicating the time in ms for transitions triggered manually (via <see cref="PagerContainer"/> or <see cref="PreviousButton"/>/<see cref="NextButton"/>)</summary>
        public int ManuallyTriggeredTransitionSpeed
        {
            [DebuggerStepThrough]
            get
            {
                return this.manuallyTriggeredTransitionSpeed;
            }

            [DebuggerStepThrough]
            set
            {
                this.manuallyTriggeredTransitionSpeed = value;
            }
        }

        /// <summary>Gets or sets a value indicating the time in milliseconds between slide transitions (0 to disable auto advance)</summary>
        public int MillisecondsBetweenTransitions
        {
            [DebuggerStepThrough]
            get
            {
                return this.millisecondsBetweenTransitions;
            }

            [DebuggerStepThrough]
            set
            {
                this.millisecondsBetweenTransitions = value;
            }
        }

        /// <summary>Gets or sets a value indicating the selector for the element to use as click trigger for next slide</summary>
        public string NextButton
        {
            [DebuggerStepThrough]
            get
            {
                return this.nextButton;
            }

            [DebuggerStepThrough]
            set
            {
                this.nextButton = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to prevent slideshow from wrapping</summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Nowrap", Justification = "Refers to the CSS property 'nowrap'")]
        public bool Nowrap
        {
            [DebuggerStepThrough]
            get
            {
                return this.nowrap;
            }

            [DebuggerStepThrough]
            set
            {
                this.nowrap = value;
            }
        }

        /// <summary>Gets or sets a value indicating the selector for the element to use as pager container</summary>
        public string PagerContainer
        {
            [DebuggerStepThrough]
            get
            {
                return this.pagerContainer;
            }

            [DebuggerStepThrough]
            set
            {
                this.pagerContainer = value;
            }
        }

        /// <summary>Gets or sets a value indicating the name of event which drives the pager navigation</summary>
        public string PagerEvent
        {
            [DebuggerStepThrough]
            get
            {
                return this.pagerEvent;
            }

            [DebuggerStepThrough]
            set
            {
                this.pagerEvent = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to enable "pause on hover"</summary>
        public bool PauseOnHover
        {
            [DebuggerStepThrough]
            get
            {
                return this.pauseOnHover;
            }

            [DebuggerStepThrough]
            set
            {
                this.pauseOnHover = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to pause when hovering over pager link</summary>
        public bool PauseOnPagerHover
        {
            [DebuggerStepThrough]
            get
            {
                return this.pauseOnPagerHover;
            }

            [DebuggerStepThrough]
            set
            {
                this.pauseOnPagerHover = value;
            }
        }

        /// <summary>Gets or sets a value indicating the selector for the element to use as click trigger for previous slide</summary>
        public string PreviousButton
        {
            [DebuggerStepThrough]
            get
            {
                return this.previousButton;
            }

            [DebuggerStepThrough]
            set
            {
                this.previousButton = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether content is shown in random order or in sequence (not applicable to <see cref="Effects.shuffle"/>)</summary>
        public bool RandomOrder
        {
            [DebuggerStepThrough]
            get
            {
                return this.randomOrder;
            }

            [DebuggerStepThrough]
            set
            {
                this.randomOrder = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether in/out transitions should occur simultaneously</summary>
        public bool SimultaneousInOutTransitions
        {
            [DebuggerStepThrough]
            get
            {
                return this.simultaneousInOutTransitions;
            }

            [DebuggerStepThrough]
            set
            {
                this.simultaneousInOutTransitions = value;
            }
        }

        /// <summary>Gets or sets a value indicating whether to force slides to fit within the container</summary>
        public bool SlidesFitContainer
        {
            [DebuggerStepThrough]
            get
            {
                return this.slidesFitContainer;
            }

            [DebuggerStepThrough]
            set
            {
                this.slidesFitContainer = value;
            }
        }

        /// <summary>Gets or sets a value indicating the zero-based index of the first slide to be displayed</summary>
        public int StartingSlideIndex
        {
            [DebuggerStepThrough]
            get
            {
                return this.startingSlideIndex;
            }

            [DebuggerStepThrough]
            set
            {
                this.startingSlideIndex = value;
            }
        }

        /// <summary>Gets or sets a value indicating the transition effect or effects</summary>
        public Effects TransitionEffects
        {
            [DebuggerStepThrough]
            get
            {
                return this.transitionEffects;
            }

            [DebuggerStepThrough]
            set
            {
                this.transitionEffects = value;
            }
        }

        /// <summary>Gets or sets a value indicating the speed of the 'in' transition</summary>
        public int? TransitionInSpeed
        {
            [DebuggerStepThrough]
            get
            {
                return this.transitionInSpeed;
            }

            [DebuggerStepThrough]
            set
            {
                this.transitionInSpeed = value;
            }
        }

        /// <summary>Gets or sets a value indicating the speed of the 'out' transition</summary>
        public int? TransitionOutSpeed
        {
            [DebuggerStepThrough]
            get
            {
                return this.transitionOutSpeed;
            }

            [DebuggerStepThrough]
            set
            {
                this.transitionOutSpeed = value;
            }
        }

        /// <summary>Gets or sets a value indicating the speed of the transition in ms</summary>
        public int TransitionSpeed
        {
            [DebuggerStepThrough]
            get
            {
                return this.transitionSpeed;
            }

            [DebuggerStepThrough]
            set
            {
                this.transitionSpeed = value;
            }
        }
    }
}