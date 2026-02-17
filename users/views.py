from django.shortcuts import render, get_object_or_404
from django.contrib.auth.models import User
from .models import UserProfile

# Create your views here.

def profile_view(request, username):
    user = get_object_or_404(User, username=username)
    try:
        profile = UserProfile.objects.get(user=user)
    except UserProfile.DoesNotExist:
        profile = None
    context = {'user': user, 'profile': profile}
    return render(request, 'users/profile.html', context)
