using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace UtilityWPF
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly CadCommands _cadCommand;

        // ==========================================================
        // STATUS VALUES
        // ==========================================================

        private string _drawingFilenameStatus = "Not Run";
        private string _drawingPropertiesStatus = "Not Run";
        private string _titleBlockUpdateStatus = "Not Run";
        private string _projectDrawingPropertiesStatus = "Not Run";
        private string _titleBlockCheckStatus = "Not Run";
        private string _drawingHealthStatus = "Not Run";
        private string _componentAttributesStatus = "Not Run";
        private string _catalogAssignmentsStatus = "Not Run";
        private string _zoomToExtentsStatus = "Not Run";


        public string DrawingFilenameStatus
        {
            get => _drawingFilenameStatus;
            set
            {
                _drawingFilenameStatus = value;
                OnPropertyChanged();
            }
        }

        public string DrawingPropertiesStatus
        {
            get => _drawingPropertiesStatus;
            set
            {
                _drawingPropertiesStatus = value;
                OnPropertyChanged();
            }
        }

        public string TitleBlockUpdateStatus
        {
            get => _titleBlockUpdateStatus;
            set
            {
                _titleBlockUpdateStatus = value;
                OnPropertyChanged();
            }
        }

        public string ProjectDrawingPropertiesStatus
        {
            get => _projectDrawingPropertiesStatus;
            set
            {
                _projectDrawingPropertiesStatus = value;
                OnPropertyChanged();
            }
        }

        public string TitleBlockCheckStatus
        {
            get => _titleBlockCheckStatus;
            set
            {
                _titleBlockCheckStatus = value;
                OnPropertyChanged();
            }
        }

        public string DrawingHealthStatus
        {
            get => _drawingHealthStatus;
            set
            {
                _drawingHealthStatus = value;
                OnPropertyChanged();
            }
        }

        public string ComponentAttributesStatus
        {
            get => _componentAttributesStatus;
            set
            {
                _componentAttributesStatus = value;
                OnPropertyChanged();
            }
        }

        public string CatalogAssignmentsStatus
        {
            get => _catalogAssignmentsStatus;
            set
            {
                _catalogAssignmentsStatus = value;
                OnPropertyChanged();
            }
        }

        public string ZoomToExtentsStatus
        {
            get => _zoomToExtentsStatus;
            set
            {
                _zoomToExtentsStatus = value;
                OnPropertyChanged();
            }
        }


        // ==========================================================
        // COMMANDS
        // ==========================================================

        public ICommand CheckDrawingFilenamesCommand { get; }
        public ICommand ViewDrawingFilenamesCommand { get; }

        public ICommand UpdateDrawingPropertiesCommand { get; }
        public ICommand ViewDrawingPropertiesCommand { get; }

        public ICommand UpdateTitleBlocksCommand { get; }
        public ICommand ViewTitleBlocksCommand { get; }

        public ICommand CheckProjectDrawingPropertiesCommand { get; }
        public ICommand ViewProjectDrawingPropertiesCommand { get; }

        public ICommand CheckTitleBlocksCommand { get; }
        public ICommand ViewTitleBlockCheckCommand { get; }

        public ICommand CheckDrawingHealthCommand { get; }

        public ICommand CheckComponentAttributesCommand { get; }

        public ICommand CheckCatalogAssignmentsCommand { get; }

        public ICommand ZoomToExtentsCommand { get; }
        public ICommand ZoomToExtentsDefaultCommand { get; }

        public ICommand HelpCommand { get; }
        public ICommand ResetChecklistCommand { get; }
        public ICommand CloseCommand { get; }


        // ==========================================================
        // CONSTRUCTOR
        // ==========================================================

        public MainViewModel()
        {
            _cadCommand = new CadCommands();


            // ------------------------------------------------------
            // 1. Check Drawing Filenames
            // ------------------------------------------------------

            CheckDrawingFilenamesCommand =
                new RelayCommand(CheckDrawingFilenames);

            ViewDrawingFilenamesCommand =
                new RelayCommand(ViewDrawingFilenames);


            // ------------------------------------------------------
            // 2. Update Drawing Properties
            // ------------------------------------------------------

            UpdateDrawingPropertiesCommand =
                new RelayCommand(UpdateDrawingProperties);

            ViewDrawingPropertiesCommand =
                new RelayCommand(ViewDrawingProperties);


            // ------------------------------------------------------
            // 3. Update Title Blocks
            // ------------------------------------------------------

            UpdateTitleBlocksCommand =
                new RelayCommand(UpdateTitleBlocks);

            ViewTitleBlocksCommand =
                new RelayCommand(ViewTitleBlocks);


            // ------------------------------------------------------
            // 4. Check Project and Drawing Properties
            // ------------------------------------------------------

            CheckProjectDrawingPropertiesCommand =
                new RelayCommand(CheckProjectDrawingProperties);

            ViewProjectDrawingPropertiesCommand =
                new RelayCommand(ViewProjectDrawingProperties);


            // ------------------------------------------------------
            // 5. Check Title Blocks
            // ------------------------------------------------------

            CheckTitleBlocksCommand =
                new RelayCommand(CheckTitleBlocks);

            ViewTitleBlockCheckCommand =
                new RelayCommand(ViewTitleBlockCheck);


            // ------------------------------------------------------
            // 6. Check Drawing Health
            // ------------------------------------------------------

            CheckDrawingHealthCommand =
                new RelayCommand(CheckDrawingHealth);


            // ------------------------------------------------------
            // 7. Check Component Attributes
            // ------------------------------------------------------

            CheckComponentAttributesCommand =
                new RelayCommand(CheckComponentAttributes);


            // ------------------------------------------------------
            // 8. Check Catalog Assignments
            // ------------------------------------------------------

            CheckCatalogAssignmentsCommand =
                new RelayCommand(CheckCatalogAssignments);


            // ------------------------------------------------------
            // 9. Zoom to Extents
            // ------------------------------------------------------

            ZoomToExtentsCommand =
                new RelayCommand(ZoomToExtents);

            ZoomToExtentsDefaultCommand =
                new RelayCommand(ZoomToExtentsDefault);


            // ------------------------------------------------------
            // Bottom Buttons
            // ------------------------------------------------------

            HelpCommand =
                new RelayCommand(ShowHelp);

            ResetChecklistCommand =
                new RelayCommand(ResetChecklist);

            CloseCommand =
                new RelayCommand(Close);
        }


        // ==========================================================
        // CHECKLIST ACTIONS
        // ==========================================================

        private void CheckDrawingFilenames()
        {
            // TODO:
            // Call the AutoCAD API through CadCommand.

            // Example:
            // var result = _cadCommand.CheckDrawingFilenames();

            DrawingFilenameStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        private void ViewDrawingFilenames()
        {
            // TODO:
            // Open the most recent drawing filename results.
        }


        // ==========================================================
        // 2. UPDATE DRAWING PROPERTIES
        // ==========================================================

        private void UpdateDrawingProperties()
        {
            // TODO:
            // var result = _cadCommand.UpdateDrawingProperties();

            DrawingPropertiesStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        private void ViewDrawingProperties()
        {
            // TODO:
            // Open the most recent drawing property results.
        }


        // ==========================================================
        // 3. UPDATE TITLE BLOCKS
        // ==========================================================

        private void UpdateTitleBlocks()
        {
            // TODO:
            // var result = _cadCommand.UpdateTitleBlocks();

            TitleBlockUpdateStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        private void ViewTitleBlocks()
        {
            // TODO:
            // Open the most recent
            // "Update Title Blocks" results.
        }


        // ==========================================================
        // 4. CHECK PROJECT AND DRAWING PROPERTIES
        // ==========================================================

        private void CheckProjectDrawingProperties()
        {
            // TODO:
            // var result =
            //     _cadCommand.CheckProjectDrawingProperties();

            ProjectDrawingPropertiesStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        private void ViewProjectDrawingProperties()
        {
            // TODO:
            // Open the most recent
            // project/drawing property results.
        }


        // ==========================================================
        // 5. CHECK TITLE BLOCKS
        // ==========================================================

        private void CheckTitleBlocks()
        {
            // TODO:
            // var result = _cadCommand.CheckTitleBlocks();

            TitleBlockCheckStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        private void ViewTitleBlockCheck()
        {
            // TODO:
            // Open the most recent
            // "Check Title Blocks" results.
        }


        // ==========================================================
        // 6. CHECK DRAWING HEALTH
        // ==========================================================

        private void CheckDrawingHealth()
        {
            // TODO:
            // var result = _cadCommand.CheckDrawingHealth();

            DrawingHealthStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        // ==========================================================
        // 7. CHECK COMPONENT ATTRIBUTES
        // ==========================================================

        private void CheckComponentAttributes()
        {
            // TODO:
            // This is where the existing attribute-checking
            // logic will eventually be connected.

            // Example:
            // var result =
            //     _cadCommand.CheckComponentAttributes();

            ComponentAttributesStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        // ==========================================================
        // 8. CHECK CATALOG ASSIGNMENTS
        // ==========================================================

        private void CheckCatalogAssignments()
        {
            // TODO:
            // var result =
            //     _cadCommand.CheckCatalogAssignments();

            CatalogAssignmentsStatus = "Complete";

            // TODO:
            // Store result and open ResultsWindow.
        }


        // ==========================================================
        // 9. ZOOM TO EXTENTS
        // ==========================================================

        private void ZoomToExtents()
        {
            // TODO:
            // _cadCommand.ZoomToExtents();

            ZoomToExtentsStatus = "Complete";
        }


        private void ZoomToExtentsDefault()
        {
            // TODO:
            // _cadCommand.ZoomToExtentsDefault();
        }


        // ==========================================================
        // OTHER COMMANDS
        // ==========================================================

        private void ShowHelp()
        {
            // TODO:
            // Open Help window.
        }


        private void ResetChecklist()
        {
            DrawingFilenameStatus = "Not Run";
            DrawingPropertiesStatus = "Not Run";
            TitleBlockUpdateStatus = "Not Run";
            ProjectDrawingPropertiesStatus = "Not Run";
            TitleBlockCheckStatus = "Not Run";
            DrawingHealthStatus = "Not Run";
            ComponentAttributesStatus = "Not Run";
            CatalogAssignmentsStatus = "Not Run";
            ZoomToExtentsStatus = "Not Run";
        }


        private void Close()
        {
            // TODO:
            // Window closing should eventually be
            // handled through a window service.
        }


        // ==========================================================
        // PROPERTY CHANGED
        // ==========================================================

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(name));
        }
    }


    // ==============================================================
    // RELAY COMMAND
    // ==============================================================

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool>? _canExecute;

        public RelayCommand(
            Action execute,
            Func<bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke() ?? true;
        }

        public void Execute(object? parameter)
        {
            _execute();
        }

        public event EventHandler? CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(
                this,
                EventArgs.Empty);
        }
    }
}