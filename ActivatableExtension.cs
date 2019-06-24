namespace Common.Activatable
{
	public static class ActivatableExtension
	{
		public static bool IsActive(this IActivatable a)
		{
			return a.ActivatableState.Value == ActivatableState.Active;
		}

		public static bool IsInactive(this IActivatable a)
		{
			return a.ActivatableState.Value == ActivatableState.Inactive;
		}

		public static bool IsBusy(this IActivatable a)
		{
			return a.ActivatableState.Value == ActivatableState.ToActive ||
			       a.ActivatableState.Value == ActivatableState.ToInactive;
		}

		public static bool IsActiveOrActivated(this IActivatable a)
		{
			return a.ActivatableState.Value == ActivatableState.Active ||
			       a.ActivatableState.Value == ActivatableState.ToActive;
		}

		public static bool IsInactiveOrDeactivated(this IActivatable a)
		{
			return a.ActivatableState.Value == ActivatableState.Inactive ||
			       a.ActivatableState.Value == ActivatableState.ToInactive;
		}
	}
}