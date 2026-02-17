from django.shortcuts import render
from .models import UserProfile

# Create your views here.

def profile_view(request, username):
    from django.contrib.auth.models import User
    user = User.objects.get(username=username)
    try:
        profile = UserProfile.objects.get(user=user)
    except UserProfile.DoesNotExist:
        profile = None
    context = {'user': user, 'profile': profile}
    return render(request, 'users/profile.html', context)
